using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomi
{
    public static class PathProvider
    {
        public static string HugoFilePath { get; set; }
        public static string MainFilePath { get; set; }
        public static string ArrayPath { get; set; }
        public static string ArrayLookupDictFilePath { get; set; }

        static PathProvider()
        {
            MainFilePath = @"D:\Programming\NoMI#\Files";
            HugoFilePath = Path.Combine(MainFilePath, "HUGO_edit.txt");
            ArrayPath = Path.Combine(MainFilePath, "Arrays");
            ArrayLookupDictFilePath = Path.Combine(MainFilePath, @"Arrays\outputBigDic\lookupDict.txt");
        }

    }
}
