namespace AdventOfCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int questionIdx = args.Length > 0 ? int.Parse(args[0]) : 0;
            var app= AppSelector.Select(questionIdx);
            app.Run();
        }
    }
}