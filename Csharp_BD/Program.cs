using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type casting 
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //string interpolation 
            Console.WriteLine($"sum of {a} and {b} is a "+(a + b));   
        }
    }
}
