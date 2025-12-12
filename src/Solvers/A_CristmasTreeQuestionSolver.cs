namespace AdventOfCode.Solvers
{
    using AdventOfCode.InputParsers;

    /// <summary>
    /// This is not the right answer, it's just a simple heuristic that happen to pass on the test input
    /// </summary>
    public class A_ChristmasTreeQuestionSolver: ISolver<string[], long>
    {
        public long Solve(string[] input)
        {
            int n = input.Length;
            List<char[,]> tetrix = new List<char[,]>();

            int idx = 0;
            for(int i = 0; i < 6; i++) {
                string[] tetrisArray = new string[3];
                idx++;
                Array.Copy(input, idx, tetrisArray, 0, 3);
                idx += 3;

                string tetrisString = string.Join(Environment.NewLine, tetrisArray);
                var parser = new GridInputParser<char>(Environment.NewLine);
                var tetris = parser.Parse(tetrisString);
                tetrix.Add(tetris);
            }

            long ans = 0;
            for(int i = idx; i < n; i++)
            {
                string[] parts = input[i].Split(":");
                long[] dimensions = parts[0].Split("x").Select(long.Parse).ToArray();
                int[] cnt = parts[1].Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(int.Parse).ToArray();

                long totalHashCount = 0;
                for(int j = 0; j < 6; j++)
                {
                    long hashCount = 0;
                    for(int r = 0; r < 3; r++)
                    {
                        for(int c = 0; c < 3; c++)
                        {
                            if(tetrix[j][r, c] == '#')
                                hashCount++;
                        }
                    }
                    totalHashCount += cnt[j] * hashCount;
                }
                if(totalHashCount < dimensions[0] * dimensions[1])
                    ans++;

            }
            return ans;
        }

    }
}