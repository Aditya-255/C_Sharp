using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class inc
    {
        public static void Main(string [] args)
        {
            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++;
            Console.WriteLine(res);
        }
    }
}
