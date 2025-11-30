namespace AdventOfCode.Readers
{
    public class InputReader: IInputReader
    {
        string inputFileName;

        public InputReader(int idx)
        {
            this.inputFileName = Constants.inputFilePrefix + idx.ToString() + Constants.inputFileExtension;
        }

        public string Read()
        {
            string dataPath = Path.Combine(AppContext.BaseDirectory, Constants.inputDirectory);
            string filePath = Path.Combine(dataPath, this.inputFileName);

            return File.ReadAllText(filePath);
        }
    }
}