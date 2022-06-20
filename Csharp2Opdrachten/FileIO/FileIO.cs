using System;
using System.IO;

namespace Csharp2Opdrachten
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string[] Text = File.ReadAllLines(@"C:\projects\f2m4\GD\text.txt.txt");

            foreach (string line in Text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
