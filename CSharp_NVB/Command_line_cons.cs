using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    class Emp
    {
        int id;
        public Emp()
        {
            
        }
        public void print1()
        {
            Console.WriteLine("Employee id is: " + id);
        }
    }
    internal class Command_line_cons
    {
        public static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.print1();
        }
    }
}
