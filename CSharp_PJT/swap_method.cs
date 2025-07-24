using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class swap_method
    {
        static void swap(ref int a,ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;

            a = a + b;  
            b = a - b;
            a = a - b;
        }
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            swap(ref a,ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }
    }
}
