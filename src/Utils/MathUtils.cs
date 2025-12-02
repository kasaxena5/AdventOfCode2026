namespace AdventOfCode.Utils
{
    public static class MathUtils
    {
        public static long Pow(long n, long x)
        {
            if(x == 0)
                return 1;
            if(x % 2 == 0) {
                return Pow(n * n, x / 2);
            }
            else {
                return n * Pow(n * n, x / 2);
            }
        }

        public static long Sqrt(long n)
        {
            long l = 0, r = Math.Min(100000000, n + 1);
            while(l < r)
            {
                long mid = l + (r - l) / 2;
                // T T T T T F F F F F F
                if(mid * mid > n) {
                    r = mid;
                }
                else {
                    l = mid + 1;
                }
            }

            return l - 1;
        }

    }
}