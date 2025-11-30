namespace AdventOfCode.Writers
{
    public class OutputWriter: IOutputWriter
    {
        int idx;

        public OutputWriter(int idx)
        {
            this.idx = idx;
        }

        public void Write(string content)
        {
            Console.Write(content);
        }
    }

}