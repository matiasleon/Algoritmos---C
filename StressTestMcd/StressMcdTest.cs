
using System;

namespace StressTestMcd
{
    class StressMcdTest
    {
        static void Main(string[] args)
        {
            var random = new Random();
            while (true)
            {
                var a = random.Next(1, 1000000000);
                var b = random.Next(1, 1000000000);
                var slow = SlowMcd(a, b);
                var fast = FastMcd(a, b);
                if (slow != fast)
                {
                    Console.WriteLine("Error "+ a +" " +b);
                    Console.WriteLine("Slow: ", slow);
                    Console.WriteLine("Fast ", fast);
                    break;
                }
                Console.WriteLine(a + " " + b);
                Console.WriteLine("OK");
            }
        }
        private static Int64 FastMcd(Int64 a, Int64 b)
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

        private static Int64 SlowMcd(Int64 a, Int64 b)
        {
            var currentMcd = 1;
            for (int d = 2; d <= a && d <= b; ++d)
            {
                if (a % d == 0 && b % d == 0)
                {
                    if (d > currentMcd)
                    {
                        currentMcd = d;
                    }
                }
            }
            return currentMcd;
        }
    }
}
