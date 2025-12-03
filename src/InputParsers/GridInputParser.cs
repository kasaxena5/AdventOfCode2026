namespace AdventOfCode.InputParsers
{
    public class GridInputParser<T> : IInputParser<T[,]>
    {
        string delimiter = Environment.NewLine;

        public GridInputParser(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public T[,] Parse(string input)
        {
            string[] rows = input.Split(this.delimiter, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            int n = rows.Length;
            if(n == 0)
                return new T[0, 0];

            int m = rows[0].Length;
            T[,] grid = new T[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (typeof(T) == typeof(int)) {
                        grid[i, j] = (T)Convert.ChangeType(rows[i][j] - '0', typeof(T));
                    }
                    else {
                        grid[i, j] = (T)Convert.ChangeType(rows[i][j], typeof(T));
                    }
                }
            }

            return grid;
        }
    }
}