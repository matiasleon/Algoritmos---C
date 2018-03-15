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
            var number = int.Parse(numberString) - 1;

            var array = new Int64[int.Parse(numberString)];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < number; i++)
            {
                array[i] = array[i-1] + array[i-2];
            }
            Console.WriteLine(array[number - 1]);
        }
    }
}
