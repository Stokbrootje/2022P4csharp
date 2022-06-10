using System;
using System.IO;

namespace StringSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringText = File.ReadAllText(@"C:\projects\f2m4\GD\csharp\Csharp2Opdrachten\stringsplit.txt");
            string[] text = stringText.Split(':',',');

            foreach (string Text in text)
                Console.WriteLine(Text);

        }
    }
}
