using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();
            var number = int.Parse(numberString);

            Int64 last = 1;
            Int64 last2 = 0;
            Int64 fibonnacciNumber = 0;
            for (int i = 2; i <= number; i++)
            {
                fibonnacciNumber = last + last2;
                last2 = last;
                last = fibonnacciNumber;
            }
            Console.WriteLine(fibonnacciNumber);
            while (true)
            {
                
            }
        }
    }
}
