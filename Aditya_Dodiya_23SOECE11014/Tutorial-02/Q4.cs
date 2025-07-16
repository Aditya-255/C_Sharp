using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = arr;
            Console.WriteLine("Original array:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Duplicate array: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
        }
    }
}
