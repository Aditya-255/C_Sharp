using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_01
{
    internal class Q20
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                    if (j < i)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
