namespace AdventOfCode.Solvers
{
    using AdventOfCode.Utils;

    public class B_CafeteriaQuestionSolver: ISolver<string[], long>
    {
        private (long, long)[] MergeRanges((long, long)[] ranges)
        {
            List<(long, long)> mergedRanges = new List<(long, long)>();
            Array.Sort(ranges);
            (long, long) currentRange = ranges.First();
            foreach(var range in ranges)
            {
                (long left, long right) = range;
                (long currentLeft, long currentRight) = currentRange;
                if(left > currentRight)
                {
                    mergedRanges.Add(currentRange);
                    currentRange = range;
                }
                else
                {
                    currentRange = (currentLeft, Math.Max(currentRight, right));
                }
            }
            mergedRanges.Add(currentRange);


            return mergedRanges.ToArray();
        }

        public long Solve(string[] input)
        {
            var ranges = input
            .Where(range => range.Contains("-"))
            .Select(range => {
                var pair = range.Split("-");
                return (long.Parse(pair[0]), long.Parse(pair[1]));
            })
            .ToArray();

            ranges = MergeRanges(ranges);

            long count = 0;
            foreach (var range in ranges)
            {
                (long left, long right) = range;
                count += right - left + 1;
            }

            return count;
        }

    }
}