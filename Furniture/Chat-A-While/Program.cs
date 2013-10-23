using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat_A_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AreaCode = new int[6] {262, 414, 608, 715, 815, 920};
            double[] Rate = new double[6] {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
            double Price;
            string Minutes, Area;

            Console.WriteLine("Input area code");
            Area = Console.ReadLine();

            Console.WriteLine("Input length of call in minutes");
            Minutes = Console.ReadLine();

            for (int i = 0; i < AreaCode.Length; i++)
            {
                if (Area == AreaCode[i].ToString())
                {
                    Price = Rate[i] * Convert.ToInt32(Minutes);
                    Console.WriteLine("This call costs: $" + Price);
                }
                break;
            }

        }
    }
}
