namespace AdventOfCode.Apps
{
    using AdventOfCode.InputParsers;
    using AdventOfCode.OutputParsers;
    using AdventOfCode.Readers;
    using AdventOfCode.Solvers;
    using AdventOfCode.Writers;

    public class SampleQuestionApp : IApp<string[], string[]>
    {
        public IInputParser<string[]> inputParser => new StringArrayInputParser();
        public IOutputParser<string[]> outputParser => new StringArrayOutputParser();
        public ISolver<string[], string[]> solver => new SampleQuestionSolver();
        public IOutputWriter writer => writerInternal;
        public IInputReader reader => readerInternal;

        private IOutputWriter writerInternal;
        private IInputReader readerInternal;

        public SampleQuestionApp(IInputReader reader, IOutputWriter writer)
        {
            this.writerInternal = writer;
            this.readerInternal = reader;
        }
    }
}