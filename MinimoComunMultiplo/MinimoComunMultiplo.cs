
using System;

namespace MinimoComunMultiplo
{
    class MinimoComunMultiplo
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var array = input.Split(' ');
            var a = long.Parse(array[0]);
            var b = long.Parse(array[1]);

            Console.WriteLine(FastMcm(a, b));
        }

        private static long FastMcd(long a, long b)
        {
            var mod = a % b;
            while (mod != 0)
            {
                a = b;
                b = mod;
                mod = a % b;
            }
            return b;
        }

        private static long FastMcm(long a, long b)
        {
            return a * b / FastMcd(a, b);
        }
    }
}
