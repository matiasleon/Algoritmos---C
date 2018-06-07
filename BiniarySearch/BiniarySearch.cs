using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiniarySearch
{
    class BiniarySearch
    {
        static void Main(string[] args)
        {
            var orderedArray = ReadData();
            var numbersToSearch = ReadData();
            var results = String.Empty;
            for (int i = 0; i < numbersToSearch.Length; i++)
            {
                var position = BinarySearch(orderedArray, numbersToSearch[i],0 , orderedArray.Length - 1);
                results = results + " " + position;
            }
            
            Console.WriteLine(results);
            Console.ReadLine();
        }

        static int BinarySearch( int[] array, int key, int low, int high )
        {
            if (high < low)
            {
                return -1;
            }
            
            var mid = low + (high - low) / 2;
            if (key == array[mid])
            {
                return mid;
            }

			if (key < array[mid])
            {
                return BinarySearch(array, key, low, mid - 1);
            }
            else
            {
                return BinarySearch(array, key, mid + 1, high);
            }
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

        // para hacer un stress test
        static int linearSearch(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) return i;

            }
            return -1;
        }
    }
}
