using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex12
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 };
            int x = 4;
            int j=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == x)
                {
                    j = 1;
                }
                else
                {
                    j = 0;
                }
            }
            if (j == 1)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }
        }
    }
}
