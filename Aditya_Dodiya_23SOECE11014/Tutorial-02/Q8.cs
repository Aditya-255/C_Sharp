using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q8
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 13, 25, 48, 78, 56, 21, 23 };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
