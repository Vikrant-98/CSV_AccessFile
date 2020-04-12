using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CSV_AccessFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\The Daddy\source\repos\CSV_AccessFile\CSV_AccessFile\Text.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
