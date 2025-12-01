namespace AdventOfCode.OutputParsers
{
    using System.Text;

    public class StandardOutputParser<T> : IOutputParser<T>
    {
        public string Parse(T output)
        {
            return output?.ToString() ?? string.Empty;
        }
    }
}