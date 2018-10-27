using System;
namespace Deserialise.Logic
{
    public class JsonFile
    {
        // gets the data.txt file path from the bin folder
        public static readonly string FilePath = Environment.CurrentDirectory + "/data.txt";

        public static string GetJsonDataFromTextFile()
        {
            string dataFromTheTextFile = System.IO.File.ReadAllText(FilePath);

            return dataFromTheTextFile;
        }
    }
}
