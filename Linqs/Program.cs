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
                    Console.WriteLine(fruit);
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

            //Order of Operations

            List<string> names = new List<string>
            {
                 "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                 "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                 "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                 "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                 "Francisco", "Tre"
            };

            var descend = from a in names
                          orderby a descending
                          select a;

            Console.WriteLine("List alphabetically");
            foreach(var a in descend)
            {
                Console.WriteLine(a);
            }


            //
            List<int> numbersToAscend = new List<int>
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var ascend = from aNum in numbersToAscend
                         orderby aNum ascending
                         select aNum;

            Console.WriteLine("List numbers");
            foreach(var aNum in ascend)
            {
                Console.WriteLine(aNum);
            }

            //How many numbers in in this list
            Console.WriteLine("Get Total of numbers in a list");
            List<int> getNumbers = new List<int>
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var getAll = getNumbers.Count();
            Console.WriteLine(getAll);

            List<double> purchases = new List<double>
            {
               2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double getTotal = purchases.Sum();
            Console.WriteLine("Get Money Total?");
            Console.WriteLine(getTotal);

            //Most Expensive

            List<double> prices = new List<double>
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double getHighNum = prices.Max();
            Console.WriteLine("Get highest number");
            Console.WriteLine(getHighNum);



            Console.WriteLine("Square Number");
            List<int> wheresSquaredo = new List<int>
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            foreach (var i in wheresSquaredo.TakeWhile( i => Math.Sqrt(i) % 1 != 0)) 
                Console.WriteLine(i);

            Console.Read();
        }
    }
}
