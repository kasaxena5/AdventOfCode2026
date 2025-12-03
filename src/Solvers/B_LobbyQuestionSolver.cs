using AdventOfCode.Utils;

namespace AdventOfCode.Solvers
{
    public class B_LobbyQuestionSolver: ISolver<int[,], long>
    {
        public long Solve(int[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            long ans = 0;
            for(int i = 0; i < n; i++)
            {
                long[,] dp = new long[m, 13];
                for(int j = 0; j < m; j++)
                    dp[j, 1] = (long)input[i, j];

                for(int d = 2; d <= 12; d++) {
                    for(int j = m - d; j >= 0; j--) {
                        for(int k = j + 1; k <= m - d + 1; k++){
                            dp[j, d] = Math.Max(dp[j, d], input[i, j] * MathUtils.Pow(10, d - 1) + dp[k, d - 1]);
                        }
                    }
                }

                long mx = 0;
                for(int j = 0; j < m; j++)
                {
                    mx = Math.Max(mx, dp[j, 12]);
                }

                ans += mx;

            }
            return ans;
        }
        /**
        dp[i][j] = maximumn jth digit number that can be formed using i and digits from i+1...n 
        dp[i][j] = Math.Max(input[i] * 10 +  dp[k][j-1]) for  i < k < n
        **/

    }
}