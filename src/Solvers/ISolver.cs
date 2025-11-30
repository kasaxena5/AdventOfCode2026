namespace AdventOfCode.Solvers
{
    public interface ISolver<TInput, TOutput>
    {
        TOutput Solve(TInput input);
    }
}