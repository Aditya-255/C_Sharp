using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex11
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of Elements: " + sum);
        }
    }
}
