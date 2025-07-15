using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class Array
    {
        public static void Main(string[] args)
        {
            //    int[] arr = new int[5];
            //    arr[0] = 1;
            //    arr[1] = 2;
            //    arr[2] = 3;
            //    arr[3] = 4;
            //    arr[4] = 4;
            //    for(int i=0; i<arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //    int[] arr1= { 1, 2, 3, 4, 5 };  
            //    //for(int i = 0; i < arr1.Length; i++)
            //    //{
            //    //    Console.WriteLine(arr1[i]);
            //    //}

            //foreach(int i in arr1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //int[] arr = new int[5];
            //Console.WriteLine("enter the number:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //int sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("the sum is :" + sum);
            //int avg = 1;
            //avg= sum / arr.Length;
            //Console.WriteLine("the average is :"+avg);
            int[] arr = { 1, 2, 3, 4, 5 };
            int x = Convert.ToInt32(Console.ReadLine());
            int f = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == x)
                {
                    f = 1;
                }
            }
            if (f == 1)
            {
                Console.WriteLine("element founded in array");
            }
            else
            {
                Console.WriteLine("Element is not Found");
            }
        }   
    }
}
