namespace AdventOfCode.Apps
{
    using AdventOfCode.InputParsers;
    using AdventOfCode.OutputParsers;
    using AdventOfCode.Readers;
    using AdventOfCode.Solvers;
    using AdventOfCode.Writers;

    public class B_LobbyQuestionApp : IApp<int[,], long>
    {
        public IInputParser<int[,]> inputParser => new GridInputParser<int>(Environment.NewLine);
        public IOutputParser<long> outputParser => new StandardOutputParser<long>();
        public ISolver<int[,], long> solver => new B_LobbyQuestionSolver();
        public IOutputWriter writer => writerInternal;
        public IInputReader reader => readerInternal;

        private IOutputWriter writerInternal;
        private IInputReader readerInternal;

        public B_LobbyQuestionApp(IInputReader reader, IOutputWriter writer)
        {
            this.writerInternal = writer;
            this.readerInternal = reader;
        }
    }
}