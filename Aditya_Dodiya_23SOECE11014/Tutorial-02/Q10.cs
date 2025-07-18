using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            int[,]  arr = { {1, 2, 3 },{ 4, 5, 6 } };
            int[,] arr1 = { { 1, 2, 3 } , { 4, 5, 6 } };
            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr[i, j] + arr1[i, j];
                }
            }
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
