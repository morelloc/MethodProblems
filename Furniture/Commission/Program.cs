using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            string CarPrice;
            double Value;
            double Commissions;

            Console.WriteLine("Input the cars value.");
            CarPrice = Console.ReadLine();
            Value = Convert.ToDouble(CarPrice);

            if(Value <= 15000)
            {
                Commissions = Value * .05;
            }
            else if (Value > 15000 && Value <= 24000)
            {
                Commissions = Value * .07;
            }
            else
            {
                Commissions = Value * .1;
            }
            Console.WriteLine("Your commission is: $" + Commissions);
        }
    }
}
