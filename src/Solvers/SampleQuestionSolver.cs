namespace AdventOfCode.Solvers
{
    public class SampleQuestionSolver: ISolver<string[], string[]>
    {
        public string[] Solve(string[] input)
        {
            int n = input.Length;
            string[] ans = new string[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = input[i];
            }

            return ans;
        }

    }
}