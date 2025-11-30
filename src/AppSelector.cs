namespace AdventOfCode
{
    using AdventOfCode.Apps;
    using AdventOfCode.Readers;
    using AdventOfCode.Writers;

    internal class AppSelector
    {
        internal static IApp Select(int idx)
        {
            var reader = new InputReader(idx);
            var writer = new OutputWriter(idx);

            switch (idx)
            {
                case 0:
                    return new SampleQuestionApp(reader, writer);
                default:
                    return new SampleQuestionApp(reader, writer);
            }
        }
    }
}