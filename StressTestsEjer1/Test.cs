
using System;

namespace StressTestsEjer1
{
    class Test
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var random = new Random();
                var n = random.Next(0, 45);

                var fast = Fastfibo(n);
                var slow = Slowfibo(n);

                if (fast != slow)
                {
                    Console.WriteLine("Error: ");
                    Console.WriteLine("fast: " + fast);
                    Console.WriteLine("slow: " + slow);
                    Console.WriteLine("Case: "+n);
                    break;
                }

                Console.WriteLine(n);
                Console.WriteLine("OK");
            }
        }

        private static Int64 Fastfibo(int n)
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

        private static Int64 Slowfibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Slowfibo(n - 1) + Slowfibo(n - 2);
        }
    }
}
