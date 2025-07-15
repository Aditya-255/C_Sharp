using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class add_of_2_arr
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Console.WriteLine("enter the number for array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] arr1 = new int[2, 2];
            Console.WriteLine("enter the number for array 2:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            int[,] arr2= new int[2, 2];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i,j] = arr[i,j] + arr1[i,j];
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+"+"+arr1[i,j]+"="+arr2[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
