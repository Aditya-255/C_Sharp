using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class P8
    {
        public static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if ((i+j)%2==0)
                    {
                        Console.Write("#"+" ");
                    }
                    else
                    {
                        Console.Write("*" + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
