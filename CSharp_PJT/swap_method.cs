using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    /// <summary>
    /// this is swap class
    /// </summary>
    internal class swap_method
    {
        /// <summary>
        /// this is swap class methos
        /// </summary>
        /// <param name="a">this field for a swap method</param>
        /// <param name="b">this field for a swap method</param>
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
            swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");
            swap_method s=new swap_method();

            swap(ref a, ref b);

        }
    }
}
