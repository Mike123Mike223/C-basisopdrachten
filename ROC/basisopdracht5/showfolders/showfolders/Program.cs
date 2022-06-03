using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showfolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string entry in Directory.GetDirectories(@"c:"))
            {
                Console.WriteLine(entry);
            }
        }
    }
}