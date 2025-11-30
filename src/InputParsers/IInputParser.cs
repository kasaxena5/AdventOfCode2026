namespace AdventOfCode.InputParsers
{
    public interface IInputParser<TInput>
    {
        TInput Parse(string input);
    }
}