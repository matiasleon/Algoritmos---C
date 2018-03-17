using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTestMinimoComunMultiplo
{
    class StressTestMinimoComunMultiplo
    {
        static void Main(string[] args)
        {
            var random = new Random();
            while (true)
            {
                var a = (long)random.Next(1, 10000);
                var b = (long)random.Next(1, 10000);
                var slow = SlowMcm(a, b);
                var fast = FastMcm(a, b);
                if (slow != fast)
                {
                    Console.WriteLine("Error " + a + " " + b);
                    Console.WriteLine("Slow: " + slow);
                    Console.WriteLine("Fast " + fast);
                    break;
                }
                Console.WriteLine(a + " " + b);
                Console.WriteLine("OK");
            }
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

        private static long SlowMcm(long a, long b)
        {
            for (long l = 1; l <= (long)a * b; ++l)
                if (l % a == 0 && l % b == 0)
                    return l;

            return (long)a * b;
        }
    }
}
