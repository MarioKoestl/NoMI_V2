using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomi
{
    public class ArrayManager
    {
        private Dictionary<int, string> arrayLookupDict;

        public ArrayManager()
        {
            arrayLookupDict = new Dictionary<int, string>();
        }

        public void CreateDictionaryFromPath(string path)
        {
            var index = 1;
            foreach (var fileName in Directory.GetFiles(path, "*.txt"))
            {
                arrayLookupDict.Add(index,fileName);
                index++;
            }
        }

        public void WriteDictionaryToFile(string filePath)
        {
            using (var file = new StreamWriter(filePath))
            {
                file.WriteLine("arrayNumber\tfilepath");
                foreach (var entry in arrayLookupDict)
                {
                    file.WriteLine($"{entry.Key}\t{entry.Value}");
                }
            }
        }

    }
}
