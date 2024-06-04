namespace DevPro
{
    public class DevProLogger
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + "DevProLog.txt";
        private TextWriter textWriter;

        public DevProLogger() 
        {
            CreateTxtFile();
        }

        private void CreateTxtFile()
        {
            if (File.Exists(path))
            {
                this.textWriter = new StreamWriter(path, true);
            }
            else {
                File.Create(path);
                this.textWriter = new StreamWriter(path);
            }
        }

        private void CloseTxtFile() {
            if (this.textWriter != null)
            {
                this.textWriter.Close();
            }
        }

        public void LogMessage(string application, string message, string level)
        {
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(level) && !string.IsNullOrEmpty(application))
            {
                string messagePattern = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] [{level.ToUpper()}] {message}";
                textWriter.WriteLine(messagePattern);
                CloseTxtFile();
            }
            else
            {
                CloseTxtFile();
                throw new ArgumentNullException("Arguments should not be null or Empty");
            }

        }
  
    }
}
