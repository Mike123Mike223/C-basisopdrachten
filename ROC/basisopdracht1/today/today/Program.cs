using System;

namespace DateTimeFormatInCSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current DateTime. It can be any DateTime object in your code.  
            DateTime aDate = DateTime.Now;

            // Format Datetime in different formats and display them
            Console.WriteLine(aDate.ToString("dd MMMM yyyy - HH:mm:ss "));
            Console.ReadKey();

            if (args != null && args.Length > 0)
            {
                Console.WriteLine($"Welkom {args[0].ToString()}");
            } else
                {
                    Console.WriteLine("Mike van Nieuwenhuizen");
                }
            
        }
    }
}

