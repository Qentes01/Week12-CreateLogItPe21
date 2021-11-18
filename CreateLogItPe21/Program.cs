using System;
using System.IO;

namespace CreateLogItPe21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string newDirectory = "LOGITPE21";
            CreateMyDirectory(newDirectory);
            
        }
        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string directoryfullpath = @$"{rootDirectory}\{myDirectoryName}";

            if (Directory.Exists(directoryfullpath)) 
            {
                Console.WriteLine($"Directory{myDirectoryName} already exists in {rootDirectory}.");

            }
            else
            {
                Directory.CreateDirectory(directoryfullpath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }
        
        }
    }
}
