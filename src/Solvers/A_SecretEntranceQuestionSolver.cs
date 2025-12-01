namespace AdventOfCode.Solvers
{
    public class A_SecretEntranceQuestionSolver: ISolver<string[], int>
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
                start = (start + turn + M) % M;
                if(start == 0)
                    cnt++;
            }
            return cnt;
        }

    }
}