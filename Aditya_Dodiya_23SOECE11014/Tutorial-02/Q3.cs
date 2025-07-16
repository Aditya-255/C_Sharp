using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Reversed array: ");
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
