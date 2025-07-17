using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class T_ex
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            string[] arr = { "zero", "one", "two", "three", "forth", "five", "six", "seven", "eight", "nine" };
            //string[] arr1=new string[4];
            int rev = 0;

            while (x > 0)
            {
                int d = x % 10;
                rev = (rev * 10) + d;
                
                x = x / 10;
                
            }
            x = rev;
            while (x>0)
            {
                int digit = x % 10;
                x = x / 10;
                Console.Write(arr[digit]+" ");
            }
            

        }
    }
}
