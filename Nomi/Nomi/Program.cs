using System;

namespace Nomi
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileManager = new FileManager();
            var arrayManager = new ArrayManager();
            //var list = fileManager.GetAllHugoSymbolNames(PathProvider.HugoFilePath,"symbol");
            arrayManager.CreateDictionaryFromPath(PathProvider.ArrayPath);
            arrayManager.WriteDictionaryToFile(PathProvider.ArrayLookupDictFilePath);
        }




    }
}