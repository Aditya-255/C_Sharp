using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class Pattern1
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <= 5; i++)
            {
                for(int j = 0; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
