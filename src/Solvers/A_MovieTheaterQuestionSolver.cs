namespace AdventOfCode.Solvers
{
    public class A_MovieTheaterQuestionSolver: ISolver<long[,], long>
    {
        public long Solve(long[,] input)
        {
            int n = input.GetLength(0);
            long ans = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    ans = Math.Max(ans, (Math.Abs(input[i, 0] - input[j, 0]) + 1) * (Math.Abs(input[i, 1] - input[j, 1]) + 1));
                }
            }
            return ans;
        }

    }
}