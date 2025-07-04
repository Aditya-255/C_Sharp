using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_01
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number:");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.Read();
        }

    }
}
