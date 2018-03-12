using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace StressTest
{
    class MaximumPairwiseProductStressTest
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                var random = new Random();
                var n = random.Next(2, 100000);
                var numeros = new int[n];
                for (int i = 0; i < n; i++)
                {
                    numeros[i] = random.Next(0, 100000);
                }
                if (Slow(numeros) != Fast(numeros))
                {
                    Console.WriteLine("Slow" + Slow(numeros) + "/n");
                    Console.WriteLine("Fast" + Fast(numeros) + "/n");
                    Console.WriteLine("Error");
                    break;
                }
                Console.WriteLine("OK");
            }
            
            while (true)
            {
                
            }
        }

        private static Int64 Slow(int[] numeros)
        {
            Int64 max = 0;
            var f = 0;
            var s = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] != numeros[j])
                    {
                        Int64 product = numeros[i] * numeros[j];
                        if (max < product)
                        {
                            f = numeros[i];
                            s = numeros[j];
                            max = product;
                        }
                    }
                }
            }

            Console.WriteLine(f);
            Console.WriteLine(s);
            return max;
        }

        private static Int64 Fast(int[] numeros)
        {
            Int64 firstNextNumber = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                var potencialFirstNumber = numeros[i];
                if (potencialFirstNumber > firstNextNumber)
                {
                    firstNextNumber = potencialFirstNumber;
                }
            }

            Int64 secondMaxNumber = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                var intNum = numeros[i];
                if (secondMaxNumber <= intNum && intNum < firstNextNumber && intNum != firstNextNumber)
                {
                    secondMaxNumber = intNum;
                }
            }
            Console.WriteLine(firstNextNumber);
            Console.WriteLine(secondMaxNumber);
            Int64 product = firstNextNumber * secondMaxNumber;
            return product;
        }
    }
}
