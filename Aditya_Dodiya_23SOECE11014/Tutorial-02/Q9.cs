using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q9
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 42, 5, 6, 7, 8, 9, 10 };
            Console.Write("original array: ");
            foreach (int i in arr) {
                Console.Write(i+" ");
            }

            int pos = 4;
            for(int i = pos; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine();
            Console.Write("array after deletion: ");
            for(int i=0;i<arr.Length-1;i++)
            {
                Console.Write(arr[i] +" ");
            }
        }
    }
}
