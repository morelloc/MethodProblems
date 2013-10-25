using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int Width = 7;
            int Height = 5;

            Area(Width, Height);
            Area(Convert.ToDouble(Width), Height);
            Area(Convert.ToDouble(Width), Convert.ToDouble(Height));

            Console.ReadKey();
        }

        public static void Area(int Width, int Height)
        {
            int Area = Width * Height;
            Console.WriteLine(Area);
        }

        public static void Area(double Width, int Height)
        {
            double Area = Width * Height;
            Console.WriteLine(Area);
        }

        public static void Area(double Width, double Height)
        {
            double Area = Width * Height;
            Console.WriteLine(Area);
        }
    }
}
