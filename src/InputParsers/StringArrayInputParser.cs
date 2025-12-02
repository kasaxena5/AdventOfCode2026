namespace AdventOfCode.InputParsers
{
    public class StringArrayInputParser : IInputParser<string[]>
    {
        string delimiter = Environment.NewLine;

        public StringArrayInputParser(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string[] Parse(string input)
        {
            return input.Split(this.delimiter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }
    }
}