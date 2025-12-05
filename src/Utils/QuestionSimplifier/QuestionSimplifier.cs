namespace AdventOfCode
{
    using System.Text.Json;
    using Microsoft.SemanticKernel;
    using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
    using AdventOfCode.Utils.QuestionSimplifier;
    using AdventOfCode.Writers;
    using AdventOfCode.Readers;

    public class QuestionSimplifier
    {
        private Kernel BuildKernel()
        {
            Kernel kernel = Kernel
                .CreateBuilder()
                .AddAzureOpenAIChatCompletion(
                    deploymentName: Environment.GetEnvironmentVariable("AZURE_OPEN_AI_DEPLOYMENT_NAME") ?? string.Empty,
                    endpoint: Environment.GetEnvironmentVariable("AZURE_OPEN_AI_ENDPOINT") ?? string.Empty,
                    apiKey: Environment.GetEnvironmentVariable("AZURE_OPEN_AI_API_KEY") ?? string.Empty)
                .Build();

            return kernel;
        }

        private string BuildSystemPrompt(int idx)
        {
            return @"
You are an expert in simplifying complex programming questions while preserving their core essence. 
You will be provided with an HTML document containing the problem statement, input/output formats, and sample inputs/outputs. 
The document contains unnecessary details, verbose explanations, useless storylines, or redundant information that do not contribute to understanding the problem.
The document may include extraneous information such as decorative elements, advertisements, or unrelated links.
Your task is to distill the provided question into a more straightforward version without losing any critical details to solve the question just like a Leetcode or AtCoder problem statement.
Focus on clarity and conciseness, ensuring that the simplified question remains faithful to the original intent and requirements.
";

        }

        private string BuildUserPrompt(int idx)
        {
            InputReader reader = new InputReader(idx, Constants.rawQuestionDirectoryPath, Constants.questionFilePrefix, Constants.rawQuestionFileExtension);
            string questionText = reader.Read();
            return $"Question document:\n {questionText}";
        }

        private async Task<Question> SimplifyQuestion(int idx, Kernel kernel)
        {
            string systemPrompt = BuildSystemPrompt(idx);

            var executionSettings = new AzureOpenAIPromptExecutionSettings
            {
                ResponseFormat = typeof(Question),
                ChatSystemPrompt = systemPrompt
            };

            string userPrompt = BuildUserPrompt(idx);

            var result = await kernel.InvokePromptAsync(userPrompt, new(executionSettings));
            if (result != null)
            {
                return JsonSerializer.Deserialize<Question>(result.ToString());
            }

            return null;
        }

        public async Task BuildSimplifiedQuestion(int idx)
        {
            Kernel kernel = BuildKernel();
            Question question = await SimplifyQuestion(idx, kernel);

            OutputWriter writer = new OutputWriter(idx);
            writer.Write(question.ToString());
        }

    }
}