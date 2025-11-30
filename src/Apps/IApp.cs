namespace AdventOfCode.Apps
{
    using AdventOfCode.InputParsers;
    using AdventOfCode.OutputParsers;
    using AdventOfCode.Readers;
    using AdventOfCode.Solvers;
    using AdventOfCode.Writers;

    public interface IApp
    {
        void Run();
    }

    public interface IApp<TInput, TOutput>: IApp
    {
        IInputParser<TInput> inputParser { get; }

        IOutputParser<TOutput> outputParser { get; }

        ISolver<TInput, TOutput> solver { get; }

        IInputReader reader { get; }

        IOutputWriter writer { get; }


        void IApp.Run()
        {
            string rawInput = reader.Read();

            var input = inputParser.Parse(rawInput);

            var output = solver.Solve(input);

            var rawOutput = outputParser.Parse(output);

            writer.Write(rawOutput);
        }
    }
}