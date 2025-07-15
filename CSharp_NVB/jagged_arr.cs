using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class jagged_arr
    {
        public static void Main(string[] args)
        {
            int[][] arr= new int[7][];
            arr[0]=new int[1];
            arr[1]=new int[2];
            arr[2]=new int[3];
            arr[3]=new int[4];
            arr[4] = new int[3];
            arr[5] = new int[2];
            arr[6] = new int[1];
            Console.WriteLine("enter jagged array elements:");
            for (int i = 0; i<arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i<arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine() ;
            }
        }
    }
}
