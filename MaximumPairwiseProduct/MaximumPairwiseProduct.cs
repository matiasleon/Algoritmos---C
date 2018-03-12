
using System;
using System.Linq;

namespace MaximumPairwiseProduct
{
    class MaximumPairwiseProduct
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var n = Int64.Parse(input1);

            var input2 = Console.ReadLine();
            var numeros = input2.Split(' ');

            Int64 firstNextNumber = 0;
            var firstMayorNumberIndex = 0;
            for (int i = 0; i < n; i++)
            {                
                var potencialFirstNumber = Int64.Parse(numeros[i]);
                if (potencialFirstNumber > firstNextNumber && IsAcceptedNumber(potencialFirstNumber ) )
                {
                    firstNextNumber = potencialFirstNumber;
                    firstMayorNumberIndex = i;
                }
            }

            Int64 secondMaxNumber = 0;
            var secondMayorNumberIndex = 0;
            for (int i = 0; i < n; i++)
            {
                var intNum = Int64.Parse(numeros[i]);
                if (secondMaxNumber <= intNum && i  != firstMayorNumberIndex && IsAcceptedNumber(intNum))
                {
                    secondMaxNumber = intNum;
                    secondMayorNumberIndex = i;
                }
            }
            Int64 product = Int64.Parse(numeros[firstMayorNumberIndex]) * Int64.Parse(numeros[secondMayorNumberIndex]);
            Console.WriteLine(product);
        }


        private static bool IsAcceptedNumber(Int64 number)
        {
            return number >= 0 && number <= 200000;
        }
    }
}
