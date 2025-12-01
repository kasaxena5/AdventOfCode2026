namespace AdventOfCode.Solvers
{
    public class B_SecretEntranceQuestionSolver: ISolver<string[], int>
    {
        public int Solve(string[] input)
        {
            int[] turns = input
                .Select(line => ((line.First() == 'L') ? "-" : "") + line.Substring(1))
                .Select(int.Parse)
                .ToArray();
            
            int M = 100;
            int start = 50;
            int cnt = 0;
            foreach(int turn in turns)
            {
                int original_start = start;
                int crosses = 0;

                start = start + turn;
                while(start < 0 || start > M) {
                    if(start > M)
                    {
                        start -= M;
                        crosses++;
                    }
                    else if(start < 0)
                    {
                        start += M;
                        crosses++;
                    }
                }

                if(start == M || start == 0)
                {
                    crosses++;
                    start = 0;
                }

                if(original_start == 0 && turn < 0)
                    crosses--;

                cnt += crosses;
            }

            return cnt;
        }

    }
}