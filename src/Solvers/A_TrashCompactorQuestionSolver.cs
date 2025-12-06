using AdventOfCode.Utils;

namespace AdventOfCode.Solvers
{
    public class A_TrashCompactorQuestionSolver: ISolver<string[,], long>
    {
        public long Solve(string[,] input)
        {
            PrintUtils<string>.Print(input);
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            long sum = 0;
            for(int j = 0; j < m; j++)
            {
                long ans;
                if(input[n-1, j] == "*")
                {
                    ans = 1;
                    for(int i = 0; i < n - 1; i++)
                    {
                        ans *= long.Parse(input[i, j]);
                    }
                }
                else
                {
                    ans = 0;
                    for(int i = 0; i < n - 1; i++)
                    {
                        ans += long.Parse(input[i, j]);
                    }
                }
                sum += ans;
            }
            return sum;
        }

    }
}