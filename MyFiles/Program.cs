using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateFilesFromMylist(ReplaceNumbers(GetDataFromFile()));
            UptadeMyfiles(ReplaceNumbers(GetDataFromFile()));

        }

        private static string[] GetDataFromFile()
        {
            string sourceFilePath = @"C:\Users\opilane\samples\LOGITPE21\MyFiles.txt";
            string[] datafromfile = File.ReadAllLines(sourceFilePath);
            return datafromfile;

        }
        private static string[] ReplaceNumbers(string[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = sourceArray[i].Replace('4', 'a').Replace('3', 'e').Replace('0', 'o').Replace('1', 'i');
            }

            return sourceArray;

        }
        private static void CreateFilesFromMylist(string[] arrayOfNames)
        { 
            string rootPath = @"C:\Users\opilane\samples\LOGITPE21";
            for(int i = 0; 1 < arrayOfNames.Length; i++)
            {
                File.Create($@"{rootPath}/{arrayOfNames[i]}.txt");
            }
        }
        private static void UptadeMyfiles(string[] updatedArray)
        {
            string sourceFilePath = @"C:\Users\opilane\samples\LOGITPE21\MyFiles.txt";
            File.WriteAllLines(sourceFilePath, updatedArray);
        }
    }  

}
