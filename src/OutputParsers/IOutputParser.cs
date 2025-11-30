namespace AdventOfCode.OutputParsers
{
    public interface IOutputParser<TOutput>
    {
        string Parse(TOutput output);
    }
}