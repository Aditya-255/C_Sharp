using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BD
{
    internal class maxarr
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 46, 7, 3, 4, 9, -25 ,0, 5, 78, 10 };
            int max=arr[0];
            int min=arr[0];
            foreach(int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                else
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
            }
            Console.WriteLine("Maximum value in the array is: " + max);
            Console.WriteLine("Minimum value in the array is: " + min);
        }
    }
}
