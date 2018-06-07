using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderedArray = ReadData();
            var numbersToSearch = ReadData();
            var results = String.Empty;
            for (int i = 0; i < numbersToSearch.Length; i++)
            {
                var position = BinarySearch(orderedArray, numbersToSearch[i]);
                results = String.Format("{0} {1}", results, position);
            }
            Console.WriteLine(results.Trim());
            Console.ReadLine();
        }

        static int BinarySearch(int[] array, int target)
        {
            var min = 0;
            var max = array.Length - 1;
            var middle = GetMiddle(min, max);
            while(max >= min)
            {
                middle =  GetMiddle(min, max);
                if(target == array[middle])
                {
                    return middle;

                }else if(target > array[middle])
                {
                    min = middle + 1; 
                    max = array.Length - 1;
                }else
                {
                    max = middle - 1;
                }
            }
            return -1;
        }

        static int GetMiddle(int min, int max)
        {
            return min + (max - min ) / 2;
        }

        static int[] ReadData()
        {
            var stringArray = Console.ReadLine();
            var array = stringArray.Split(' ');

            var n = int.Parse(array[0]);
            var intArray = new int[n];

            for (int i = 1; i < array.Length; i++)
            {
                intArray[i-1] = int.Parse(array[i]);
            }

            return intArray;
        }
    }
}
