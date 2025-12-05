namespace AdventOfCode.Readers
{
    public class InputReader: IInputReader
    {
        string inputFileName;
        string inputFileDirectory;

        public InputReader(int idx, string inputFileDirectory = Constants.inputDirectory, string inputFilePrefix = Constants.inputFilePrefix, string inputFileExtension = Constants.inputFileExtension)
        {
            this.inputFileName = inputFilePrefix + idx.ToString() + inputFileExtension;
            this.inputFileDirectory = inputFileDirectory;
        }

        public string Read()
        {
            string dataPath = Path.Combine(AppContext.BaseDirectory, this.inputFileDirectory);
            string filePath = Path.Combine(dataPath, this.inputFileName);

            return File.ReadAllText(filePath);
        }
    }
}