using System;
using System.IO;

namespace Assignment1b
{
    /// <summary>
    /// Class to handle file input operations
    /// </summary>
    public class FileInput
    {
        private StreamReader _reader = null;
        private string _fileName;

        public FileInput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _reader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {fileName} {e.Message}");
            }
        }

        public void FileRead()
        {
            string line;
            try
            {
                while ((line = _reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e.Message}");
            }
        }

        public string FileReadLine()
        {
            try
            {
                string line = _reader.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e.Message}");
                return null;
            }
        }

        public void FileClose()
        {
            if (_reader != null)
            {
                try
                {
                    _reader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}