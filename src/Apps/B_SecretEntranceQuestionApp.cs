namespace AdventOfCode.Apps
{
    using AdventOfCode.InputParsers;
    using AdventOfCode.OutputParsers;
    using AdventOfCode.Readers;
    using AdventOfCode.Solvers;
    using AdventOfCode.Writers;

    public class B_SecretEntranceQuestionApp : IApp<string[], int>
    {
        public IInputParser<string[]> inputParser => new StringArrayInputParser();
        public IOutputParser<int> outputParser => new StandardOutputParser<int>();
        public ISolver<string[], int> solver => new B_SecretEntranceQuestionSolver();
        public IOutputWriter writer => writerInternal;
        public IInputReader reader => readerInternal;

        private IOutputWriter writerInternal;
        private IInputReader readerInternal;

        public B_SecretEntranceQuestionApp(IInputReader reader, IOutputWriter writer)
        {
            this.writerInternal = writer;
            this.readerInternal = reader;
        }
    }
}