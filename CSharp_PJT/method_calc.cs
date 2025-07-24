using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class method_calc
    {
        static int sumadd(int a,int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        public static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            Console.WriteLine($"the {a} and {b} sum is {sumadd(a,b)}");
            Console.WriteLine($"the {a} and {b} subtraction  is {sub(a, b)}");
            Console.WriteLine($"the {a} and {b} multiplication is {mul(a, b)}");
            Console.WriteLine($"the {a} and {b} division is {div(a, b)}");
        }
    }
}
