using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class Command_line
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command line arguments");
            Console.WriteLine("First arg "+args[0]);
            Console.WriteLine("second arg " + args[1]);
        }
    }
}
