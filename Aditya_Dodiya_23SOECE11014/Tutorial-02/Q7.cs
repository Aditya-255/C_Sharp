using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q7
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 13, 25, 48, 78, 56, 21, 23 };
            
            int c= 0;
            int d = 0;
            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    c++;
                }
                
                else
                {
                    d++;
                }
            }
            int[] even=new int[c];
            int[] odd=new int[d];
            int a = 0;
            int b = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[a] = arr[i];
                    Console.WriteLine("Even Number: " + arr[i]);
                }
                else
                {
                    odd[b] = arr[i];
                    Console.WriteLine("Odd Number: " + arr[i]);
                }
            }
           

        }
    }
}
