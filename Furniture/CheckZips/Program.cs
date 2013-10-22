using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;

            Console.WriteLine("Enter your zipcode to see if we are able to deliver to your area.");

            string[] ZipCode = new string[10];
            ZipCode[0] = "01234";
            ZipCode[1] = "12345";
            ZipCode[2] = "23456";
            ZipCode[3] = "34567";
            ZipCode[4] = "45678";
            ZipCode[5] = "56789";
            ZipCode[6] = "67890";
            ZipCode[7] = "78901";
            ZipCode[8] = "89012";
            ZipCode[9] = "90123";

            Input = Console.ReadLine();

            for (int i = 0; i < 100; i++)
            {
                if (Input == ZipCode[i])
                {
                    Console.WriteLine("We can deliver to your area.");
                }
                else
                {
                    Console.WriteLine("We cannot deliver to your area.");
                }
                break;
            }






        }
    }
}
