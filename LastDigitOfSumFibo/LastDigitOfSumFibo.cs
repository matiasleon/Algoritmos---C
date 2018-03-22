using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitOfSumFibo
{
    class LastDigitOfSumFibo
    {
        static void Main(string[] args)
        {
            var numberString = Console.ReadLine();
            var inputNumber = int.Parse(numberString);
            var number = inputNumber + 2;

            var array = new Int64[number];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= int.Parse(numberString); i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            Console.WriteLine(array[inputNumber]);
        }
    }
}
