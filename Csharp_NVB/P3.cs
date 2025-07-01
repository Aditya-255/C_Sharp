using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_NVB
{
    internal class P3
    {
        public static void Main(string[] args)
        {
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            //int n = 10;
            //while (n >= 1)
            //{
            //    Console.WriteLine(n);
            //    n--;
            //}
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is even");
                }
            }
        }
    }
}
