namespace AdventOfCode.Apps
{
    using AdventOfCode.InputParsers;
    using AdventOfCode.OutputParsers;
    using AdventOfCode.Readers;
    using AdventOfCode.Solvers;
    using AdventOfCode.Writers;

    public class B_GiftShopQuestionApp : IApp<string[], long>
    {
        public IInputParser<string[]> inputParser => new StringArrayInputParser(",");
        public IOutputParser<long> outputParser => new StandardOutputParser<long>();
        public ISolver<string[], long> solver => new B_GiftShopQuestionSolver();
        public IOutputWriter writer => writerInternal;
        public IInputReader reader => readerInternal;

        private IOutputWriter writerInternal;
        private IInputReader readerInternal;

        public B_GiftShopQuestionApp(IInputReader reader, IOutputWriter writer)
        {
            this.writerInternal = writer;
            this.readerInternal = reader;
        }
    }
}