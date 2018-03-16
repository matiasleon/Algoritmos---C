

using System;

namespace LastDigitFibonacci
{
    class LastDigitFibonacci
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var number = Int64.Parse(input);

            Console.WriteLine(Fibo(number));
            Console.ReadLine();
        }

        private static Int64 Fibo(Int64 n)
        {
            var number = n + 2;

            var array = new Int64[number];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n];
        }
    }
}
