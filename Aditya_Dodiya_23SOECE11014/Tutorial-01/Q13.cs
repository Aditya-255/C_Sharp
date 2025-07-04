using System;
namespace Aditya_Dodiya_23SOECE11014
{
    class Q13
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci series: ");
            int a = 0, b = 1, c;
            if (n >= 1)
            {
                Console.Write(a + " ");
            }
            if (n >= 2)
            {
                Console.Write(b + " ");
            }
            for(int i = 3; i <= n; i++)
            {
                c= a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
