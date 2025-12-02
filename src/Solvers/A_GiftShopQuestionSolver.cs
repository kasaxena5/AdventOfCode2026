namespace AdventOfCode.Solvers
{
    using AdventOfCode.Utils;

    public class A_GiftShopQuestionSolver: ISolver<string[], long>
    {
        const long ID_MAX = 1000000000000;

        long CountDigits(long num, long logBase)
        {
            long cnt = 0;
            while(num > 0)
            {
                num /= logBase;
                cnt++;
            }
            return cnt;
        }

        long[] GenerateInvalidIds()
        {
            List<long> ids = new List<long>();
            for(long i = 1; i < MathUtils.Sqrt(ID_MAX); i++)
            {
                ids.Add(i * MathUtils.Pow(10, CountDigits(i, 10)) + i);
            }

            return ids.ToArray();
        }

        public long Solve(string[] input)
        {
            var ranges = input.Select(range => {
                var pair = range.Split("-");
                return (long.Parse(pair[0]), long.Parse(pair[1]));
            }).ToArray();

            var invalidIds = GenerateInvalidIds();

            long sum = 0;
            foreach (var range in ranges) {
                foreach(var invalidId in invalidIds) {
                    (long left, long right) = range;
                    if (invalidId >= left && invalidId <= right)
                    {
                        sum += invalidId;
                    }
                }
            }
            
            return sum;
        }

    }
}