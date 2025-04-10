using System;
using System.IO;

namespace Assignment1b
{
    /// <summary>
    /// Class to handle file output operations
    /// </summary>
    public class FileOutput
    {
        private StreamWriter _writer = null;
        private string _fileName;

        public FileOutput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _writer = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e.Message}");
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _writer.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {_fileName} {e.Message}");
            }
        }

        public void FileClose()
        {
            if (_writer != null)
            {
                try
                {
                    _writer.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}