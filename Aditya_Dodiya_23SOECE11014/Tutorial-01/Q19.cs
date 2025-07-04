using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_01
{
    internal class Q19
    {
        public static void Main()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    if (j < i)
                    {
                        Console.Write(" ");  // space between stars
                    }
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }

    }
}
