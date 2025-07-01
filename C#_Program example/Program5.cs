using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    public class Program5 : Program4
    {
        public static void Main(string[] args)
        {
            Program4 p = new Program4();
            p.Accept(1, "John Doe");
            p.Accept1(50000);
            p.Display();
            p.Display1();
        }
    }
}
