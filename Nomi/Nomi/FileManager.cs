using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomi
{
    public class FileManager
    {
        public FileManager()
        {
            
        }
        public List<string> GetAllHugoSymbolNames(string filePath, string columnValue)
        {
            if (!File.Exists(filePath)) return new List<string>();
            var symbolList = new List<string>();

            using (var streamReader = new StreamReader(filePath))
            {
                var titleLine = streamReader.ReadLine();
                var symbolIndex = 0;
                if (titleLine != null)
                {
                    symbolIndex = GetColumnIndex(columnValue, titleLine.Split('\t'));
                }

                while (streamReader.Peek() >= 0)
                {
                    var line = streamReader.ReadLine();

                    if (line != null)
                    {
                        var symbol = line.Split('\t')[symbolIndex];
                        if (symbol != null)
                        {
                            symbolList.Add(symbol);
                        }
                    }
                }
            }
            return symbolList;
        }
        private int GetColumnIndex(string value, string[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].ToLower().Equals(value))
                    return i;
            }
            return -1;
        }
    }
}
