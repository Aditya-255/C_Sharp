using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    *
//   **
//  ***
// ****
//*****
namespace CSharp_PJT
{
    internal class Pattern6
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.Write();
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
