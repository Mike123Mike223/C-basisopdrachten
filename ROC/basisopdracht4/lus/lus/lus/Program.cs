using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lus
{
    internal class Program
    {


        public static void Main(string[] args)
        {

            int n = 10;
            int w = 0;
            Console.WriteLine();
            for (int i = 0; i < n; i++)

            {
                Console.Write(w + ":  ");
                w++;
                for (int j = 0; j <= i; j++)
                {

                    if (j % 2 != 0)
                    {

                        Console.Write("odd (" + j.ToString() + ") ");
                    }
                    else
                    {

                        Console.Write("even (" + j.ToString() + ") ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = n; i >= 0; i--)
            {
                Console.Write(w + ": ");
                w++;
                for (int j = 0; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("odd (" + j.ToString() + ") ");
                    }
                    else
                    {
                        Console.Write("even (" + j.ToString() + ") ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
