using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int Number;

            Console.WriteLine("Enter a number.");
            Input = Console.ReadLine();
            Number = Convert.ToInt32(Input);

            Squared(Number);
            Cubed(Number);
            Console.ReadKey();
        }

        public static void Squared(int Number)
        {
            int Square = Number * Number;
            Console.WriteLine(Square);
        }
       
        public static void Cubed(int Number)
        {
            int Cube = Number * Number * Number;
            Console.WriteLine(Cube);
        }
    }
}
