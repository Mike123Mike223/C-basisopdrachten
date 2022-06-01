using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double getal = double.Parse(args[0]);
            string teken = args[1];
            double getal2 = double.Parse(args[2]);
            if (teken == "+")
            {
                double oplossing = getal + getal2;
                Console.WriteLine("Oplossing: " + getal + " + " + getal2 + " = " + oplossing);
            }
            if (teken == "-")
            {
                double oplossing = getal - getal2;
                Console.WriteLine("Oplossing: " + getal + " - " + getal2 + " = " + oplossing);
            }
            if (teken == "x")
            {
                double oplossing = getal * getal2;
                Console.WriteLine("Oplossing: " + getal + " x " + getal2 + " = " + oplossing);
            }
            if (teken == ":")
            {
                double oplossing = getal / getal2;
                Console.WriteLine("Oplossing: " + getal + " : " + getal2 + " = " + oplossing);
            }
        }
    }
}