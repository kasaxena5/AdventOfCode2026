
namespace AdventOfCode.Utils.QuestionSimplifier
{
    public class Question
    {
        public string Statement { get; set; }


        public string InputFormat { get; set; }

        public string OutputFormat { get; set; }

        public string SampleInput { get; set; }

        public string SampleOutput { get; set; }

        public override string ToString()
        {
            // Return a formatted string representation of the Question object in markdown style
            return $"# Problem Statement\n\n{Statement}\n\n## Input Format\n\n{InputFormat}\n\n## Output Format\n\n{OutputFormat}\n\n## Sample Input\n\n```\n{SampleInput}\n```\n\n## Sample Output\n\n```\n{SampleOutput}\n```";
        }
    }
}