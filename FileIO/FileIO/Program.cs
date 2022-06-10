using System;
using System.IO;

namespace FileIO
{
    internal class File
    {
        static void Main(string[] args)
        {
           string[] Text = File.ReadAllLines(@"C:/project/f2m4/GD/text.txt");

            foreach (string line in Text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
