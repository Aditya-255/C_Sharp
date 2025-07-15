using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class array_ex
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            foreach(int i in arr)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > x)
                {
                    x = arr[i];
                }
            }
            Console.WriteLine("maximum element is :"+x);
        }
    }
}
