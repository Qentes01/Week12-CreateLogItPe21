using System;
using System.IO;

namespace Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetRandomQuote());
        }

        public static string GetRandomQuote()
        {
            string filePath = @"C:\Users\opilane\samples\49 Wise Quotes That Will Inspire You to Succeed in Life.txt";
            string[] wiseQuotes = File.ReadAllLines(filePath);
            Console.WriteLine(wiseQuotes[0]);
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, wiseQuotes.Length);

            return wiseQuotes[randomIndex];
        }
    }
}