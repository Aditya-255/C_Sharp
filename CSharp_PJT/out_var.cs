using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class out_var
    {
        /// <summary>
        /// this is for out variable class
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void change(out int a,out int b)
        {
            a = 100;
            b = 200;

        }
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"the value of before change {a} and {b}");
            change(out a,out b);
            Console.WriteLine($"the value of after change {a} and {b}");
        }
    }
}
