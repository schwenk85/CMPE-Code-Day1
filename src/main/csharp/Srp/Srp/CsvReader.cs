using System.Collections.Generic;
using System.IO;

namespace Srp
{
    public class CsvReader
    {
        private FileReader _fileReader;
        private CsvParser _csvParser;
          
        public CsvReader(string filename)
        {
            _fileReader = new FileReader(filename);
            _csvParser = new CsvParser();

            ParseCsv();
        }

        public CsvParser CsvParser => _csvParser;

        private void ParseCsv()
        {
            _csvParser.ParseFile(_fileReader.GetAllLinesOfFile());
        }
    }

    public class FileReader
    {
        private readonly string _filename;

        public FileReader(string filename)
        {
            _filename = filename;
        }

        public IEnumerable<string> GetAllLinesOfFile()
        {
            return File.ReadAllLines(_filename);
        }
    }

    public class CsvParser
    {
        private List<string[]> _records = new List<string[]>();

        public string[] Header { get; private set; }

        public List<string[]> Records => _records;

        public void ParseFile(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                if (Header == null)
                {
                    ParseHeader(line);
                }
                else
                {
                    var record = ParseRecord(line);
                    _records.Add(record);
                }
            }
        }

        private static string[] ParseRecord(string line)
        {
            return line.Split(',');
        }

        private void ParseHeader(string line)
        {
            Header = ParseRecord(line);
        }
    }
}
