using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    internal class Program2
    {
        void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        void add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }

        public static void Main(String[] args)
        {
            Program2 p = new Program2();
            p.add(10, 20);
            p.add(10, 20, 30);

            Program3_subclass p1 = new Program3_subclass();
            p1.accept(101, "John Doe");
            p1.display();
            p1.accept1(25000);
            p1.display1();
        }

    }
}
