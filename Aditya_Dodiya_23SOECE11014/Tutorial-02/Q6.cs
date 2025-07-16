using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q6
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 8, 6, 50, 100 };
            int max = arr[0];
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
                else
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            }
            Console.WriteLine("Maximum element in the array is: " + max);
            Console.WriteLine("Minimum element in the array is: " + min);
        }
    }
}
