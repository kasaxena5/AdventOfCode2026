namespace AdventOfCode.Solvers
{
    using AdventOfCode.Utils;

    public class A_CafeteriaQuestionSolver: ISolver<string[], long>
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

            var queries = input
            .Where(query => !query.Contains("-"))
            .Select(long.Parse)
            .ToArray();

            ranges = MergeRanges(ranges);

            SortedDictionary<long, (long ,long)> mp = new SortedDictionary<long, (long, long)>();
            SortedSet<long> s = new SortedSet<long>();
            foreach(var range in ranges)
            {
                (long left, long right) = range;
                mp.Add(left, range);
                s.Add(left);
            }

            long count = 0;
            foreach(long query in queries)
            {
                var view = s.GetViewBetween(long.MinValue, query);
                long lb = (view.Count > 0) ? view.Max : -1;
                if(lb != -1 && mp[lb].Item2 >= query && mp[lb].Item1 <= query)
                {
                    count++;
                }
            }
            
            return count;
        }

    }
}