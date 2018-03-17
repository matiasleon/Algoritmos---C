using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mcd
{
    class Mcd
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var array = input.Split(' ');
            var a = Int64.Parse(array[0]);
            var b = Int64.Parse(array[1]);

            Console.WriteLine(FastMcd(a, b));
            Console.ReadLine();
        }

        //Se utiliza el algoritmo de euclides
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
    }
}
