using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4 4 4
//4 1 4
//4 1 4
//4 1 4
//4 1 4
namespace CSharp_PJT
{
    internal class P7
    {
        public static void Main(string[] args)
        {
            int n = 5;
            for(int i=0; i <= n; i++)
            {
                for(int j = 3; j >=1; j--)
                {
                    if(i==0 || i == n)
                    {
                        Console.Write((n)+" ");
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write((i) + " ");
                        }
                        else{
                            Console.Write(n + " ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
