using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BD
{
    internal class array
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 46, 7, 3, 4, 9, -25 ,0, 5, 78, 10 };

            var rev = arr.Reverse();
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.Write("Reverse array:");
            foreach (int i in rev)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Array.Sort(arr);
            Console.Write("Sorted array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }

        
    }
}
