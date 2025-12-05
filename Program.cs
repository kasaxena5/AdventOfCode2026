namespace AdventOfCode
{
    using DotNetEnv;

    public class Program
    {
        public static void Main(string[] args)
        {
            Env.Load();
            int questionIdx = args.Length > 0 ? int.Parse(args[0]) : 0;
            var app= AppSelector.Select(questionIdx);
            app.Run();
        }
    }
}