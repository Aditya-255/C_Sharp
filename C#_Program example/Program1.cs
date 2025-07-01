using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    internal class Program1
    {
        // Data Encapsulation using methods
        private int rno;
        private string sname;
        void Accept(int rno, string sname)
        {
            this.rno = rno;
            this.sname = sname;
        }
        void Display()
        {
            Console.WriteLine("Roll No: {0} and name is {1}", rno, sname);
        }
        static void Main()
        {
            Program1 p = new Program1();
            p.Accept(101, "John Doe");
            p.Display();
            p.Accept(102, "Aditya");
            p.Display();
        }
    }
}
