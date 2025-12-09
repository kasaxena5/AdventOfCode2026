namespace AdventOfCode.Solvers
{
    public class B_MovieTheaterQuestionSolver: ISolver<long[,], long>
    {
        private bool InsideRectangle(int src, int dst, int idx, long[,] input)
        {
            long maxX = Math.Max(input[src, 0], input[dst, 0]);
            long minX = Math.Min(input[src, 0], input[dst, 0]);
            long maxY = Math.Max(input[src, 1], input[dst, 1]);
            long minY = Math.Min(input[src, 1], input[dst, 1]);

            long x = input[idx, 0];
            long y = input[idx, 1];
            if(x > minX && x < maxX && y > minY && y < maxY)
                return true;

            return false;
        }
        private bool CrossRectangle(int src, int dst, int idx, int prevIdx, long[,] input)
        {
            long maxX = Math.Max(input[src, 0], input[dst, 0]);
            long minX = Math.Min(input[src, 0], input[dst, 0]);
            long maxY = Math.Max(input[src, 1], input[dst, 1]);
            long minY = Math.Min(input[src, 1], input[dst, 1]);

            long x = input[idx, 0];
            long y = input[idx, 1];
            long prevX = input[prevIdx, 0];
            long prevY = input[prevIdx, 1];
            if(x > minX && x < maxX && ((y <= minY && prevY >= maxY) || (y >= maxY && prevY <= minY)))
                return true;
            if(y > minY && y < maxY && ((x <= minX && prevX >= maxX) || (x >= maxX && prevX <= minX)))
                return true;
            return false;

        }
        private bool CanReach(int src, int dst, long[,] input)
        {
            int n = input.GetLength(0);
            int idx = src;
            int prevIdx = src;
            while(idx != dst)
            {
                if(InsideRectangle(src, dst, idx, input) || CrossRectangle(src, dst, idx, prevIdx, input))
                {
                    return false;
                }
                prevIdx = idx;
                idx = (idx + 1) % n;
            }
            return true;
        }
        public long Solve(long[,] input)
        {
            int n = input.GetLength(0);
            long ans = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(CanReach(i, j, input) && CanReach(j, i, input))
                    {
                        long area = (Math.Abs(input[i, 0] - input[j, 0]) + 1) * (Math.Abs(input[i, 1] - input[j, 1]) + 1);
                        ans = Math.Max(ans, area);
                    }
                }
            }
            return ans;
        }

    }
}