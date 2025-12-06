using AdventOfCode.Utils;

namespace AdventOfCode.Solvers
{
    public class B_TrashCompactorQuestionSolver: ISolver<char[,], long>
    {
        private bool EndOfColumn(int j, char[,] input)
        {
            int n = input.GetLength(0);
            for(int i = 0; i < n; i++)
            {
                if(input[i, j] != ' ')
                    return false;
            }
            return true;
        }

        private long SolveColumn(char op, List<long> nums)
        {
            long ans;
            if (op == '*')
            {
                ans = 1;
                foreach (long num in nums)
                    ans *= num;
            }
            else
            {
                ans = 0;
                foreach (long num in nums)
                    ans += num;
            }

            return ans;
        }

        public long Solve(char[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            long sum = 0;

            List<long> nums = new List<long>();
            char op = '-';

            for(int j = 0; j < m; j++)
            {
                if(EndOfColumn(j, input))
                {
                    sum += SolveColumn(op, nums);

                    nums = new List<long>();
                    op = '-';
                    continue;
                }

                long num = 0;
                for(int i = 0; i < n - 1; i++)
                {
                    char d = input[i, j];
                    if(d == ' ' && num != 0)
                        break;
                    if(d == ' ')
                        d = '0';
                    long digit = (long)(d - '0');
                    num *= 10;
                    num += digit;
                }
                nums.Add(num);

                if(input[n - 1, j] != ' ')
                {
                    op = input[n - 1, j];
                }
            }
            sum += SolveColumn(op, nums);

            return sum;
        }

    }
}