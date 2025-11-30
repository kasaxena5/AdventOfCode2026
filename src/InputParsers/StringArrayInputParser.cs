namespace AdventOfCode.InputParsers
{
    public class StringArrayInputParser : IInputParser<string[]>
    {
        public string[] Parse(string input)
        {
            return input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }
    }
}