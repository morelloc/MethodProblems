using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMonogram("C", "J", "M");
            DisplayMonogram("A", "J", "M");
            Console.ReadKey();
        }

        public static void DisplayMonogram(string First, string Middle, string Last)
        {
            Console.WriteLine("** {0} {1} {2} **", First, Middle, Last);
        }
    }
}
