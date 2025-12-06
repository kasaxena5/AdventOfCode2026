namespace AdventOfCode.InputParsers
{
    public class GridInputParser<T> : IInputParser<T[,]>
    {
        string verticalDelimiter;
        string horizontalDelimiter;
        StringSplitOptions horizontalOptions;
        StringSplitOptions verticalOptions;

        public GridInputParser(
            string verticalDelimiter, 
            string horizontalDelimiter = Constants.every, 
            StringSplitOptions verticalOptions = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries,
            StringSplitOptions horizontalOptions = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
        {
            this.verticalDelimiter = verticalDelimiter;
            this.horizontalDelimiter = horizontalDelimiter;
            this.horizontalOptions = horizontalOptions;
            this.verticalOptions = verticalOptions;
        }

        private string[] Split(string input, string delimiter, StringSplitOptions options)
        {
            if(delimiter == Constants.every)
            {
                int n = input.Length;
                string[] split = new string[n];
                for(int i = 0; i < n; i++)
                {
                    split[i] = input.Substring(i, 1);
                }
                return split;
            }
            return input.Split(delimiter, options);
        }

        public T[,] Parse(string input)
        {
            string[] rows = 
                Split(input, this.verticalDelimiter, this.verticalOptions)
                .Where(row => !string.IsNullOrWhiteSpace(row))
                .ToArray();

            int n = rows.Length;
            if(n == 0)
                return new T[0, 0];

            int m = Split(rows[0], this.horizontalDelimiter, this.horizontalOptions).Length;
            T[,] grid = new T[n, m];
            for(int i = 0; i < n; i++)
            {
                string[] items = Split(rows[i], this.horizontalDelimiter, this.horizontalOptions);
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = (T)Convert.ChangeType(items[j], typeof(T));
                }
            }

            return grid;
        }
    }
}