using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 2)

            {

                int arg1 = int.Parse(args[0]);
                int arg2 = int.Parse(args[1]);
                int arg3 = arg1 + arg2;
                Console.WriteLine("oplossing: " + arg1 + " + " + arg2 + " = " + arg3);
            }
        }
    }
}
