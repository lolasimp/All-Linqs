using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqs
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            List<string> fruits = new List<string>() { "Lemons", "Strawberry", "Lime", "Blueberry", "Coocunut", "Apple" };

            var LFruits = fruits.Where(fruit => fruit[0] == 'L');
            {
                //getting all fruits with Ls
                foreach (var fruit in LFruits)
                {
                    Console.WriteLine("Getting all L fruits");
                    Console.Write(fruit);
                }
            }
            //Console.Read();


            //Multples of 4 or 6

            List<int> numbers = new List<int>
            {           
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            {
                foreach(int number in fourSixMultiples)
                {
                    Console.WriteLine("Getting multiples of 4 and 6");
                    Console.WriteLine(number);
                }
            }
            Console.Read();
        }
    }
}
