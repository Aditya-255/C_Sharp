using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class Sorted_array
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])

                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array:");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
