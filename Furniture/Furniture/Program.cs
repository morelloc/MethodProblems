using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;

            Console.WriteLine("Type 'P' for Pine, 'O' for Oak, or 'M' for Mahogany");
            Input = Console.ReadLine();
            
            if (Input == "P")
            {
                Console.WriteLine("A Pine table costs $100");
            }
            else if (Input == "O")
            {
                Console.WriteLine("An Oak table costs $225");
            }
            else if (Input == "M")
            {
                Console.WriteLine("A Mahogany table costs $310");
            }
            else
            {
                Console.WriteLine("No Price");
            }
        }
    }
}
