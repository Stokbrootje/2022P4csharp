using System;
using System.IO;

namespace Csharp2Opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\leonk");
            foreach (var sub in dir.GetFiles())
            {
                Console.Write(sub.Name);
            }
        }
    }
}