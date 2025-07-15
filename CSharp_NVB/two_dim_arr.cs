using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class two_dim_arr
    {
        public static void Main(string[] args)
    {
            //int[,] arr = new int[2, 2];
            //arr[0, 0] = 1;
            //arr[1, 0] = 2;
            //arr[0, 1] = 3;
            //arr[1, 1] = 4;
            //Console.WriteLine(arr[0, 0]);
            //Console.WriteLine(arr[1, 0]);
            //Console.WriteLine(arr[0, 1]);
            //Console.WriteLine(arr[1, 1]);

            //int[,] arr = { { 1, 2 }, { 3, 4 },{ 5, 6 } };  3X2
            //int[,] arr = { { 1, 2, 3 }, { 1, 2, 3 }, }; // 2X3
            //Console.WriteLine(arr[0,2]);


            //int[,] arr = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < arr.GetLength(0); i++){
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            int[,] arr = new int[3, 3];
            Console.WriteLine("enter the number for array:");
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for(int i=0;i<arr.GetLength(0); i++)
            {
                for(int j=0;j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            } 
        }
}
}
