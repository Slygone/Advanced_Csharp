
namespace LoggerExample
{
    public class LoggerService
    {
        private string _folderPath = @"..\..\..\logs";
        private string _filePath = @"..\..\..\logs\log.txt";

        public LoggerService() 
        {
            _folderPath = @"..\..\..\logs";
            _filePath = @"..\..\..\logs\log.txt";

            if (Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
        }

        public void Log(string message, bool isError)
        {
            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine($"Time: {DateTime.Now}");
                if(isError )
                {
                    sw.WriteLine($"ERROR message: {message}");
                }
                else
                {
                    sw.WriteLine($"INFO message: {message}");
                }
                sw.WriteLine("========================");
            }
        }
    }
}
