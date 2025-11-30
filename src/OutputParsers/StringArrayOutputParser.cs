namespace AdventOfCode.OutputParsers
{
    using System.Text;

    public class StringArrayOutputParser : IOutputParser<string[]>
    {
        public string Parse(string[] output)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var line in output)
            {
                sb.Append(line);
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}