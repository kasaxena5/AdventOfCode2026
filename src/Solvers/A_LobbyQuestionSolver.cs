namespace AdventOfCode.Solvers
{
    public class A_LobbyQuestionSolver: ISolver<int[,], long>
    {
        public long Solve(int[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            int[,] maxRight = new int[n, m];
            long ans = 0;
            for(int i = 0; i < n; i++)
            {
                int mx = input[i, m - 1];
                int maxNumber = 0;
                for(int j = m - 2; j >= 0; j--)
                {
                    maxRight[i, j] = mx;
                    mx = Math.Max(mx, input[i, j]);
                    maxNumber = Math.Max(maxNumber, input[i, j] * 10 + maxRight[i, j]);
                }
                ans += maxNumber;
            }
            return ans;
        }

    }
}