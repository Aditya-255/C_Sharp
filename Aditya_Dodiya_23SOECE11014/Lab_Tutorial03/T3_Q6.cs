using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            // Missing statement-1
            length = 10;

            // Missing statement-2
            Console.WriteLine("Object is being created, length = " + length);
        }

        public void setLength(double len)
        {
            // Missing statement-3
            length = len;
        }

        public double getLength()
        {
            // Missing statement-4
            return length;
        }
    }
    internal class T3_Q6
    {
        static void Main(string[] args)
        {
            Line line = new Line();   // Constructor sets length = 10

            // First output
            Console.WriteLine("Length of line : {0}", line.getLength());

            // Now set length to 6 (this was missing in the original code)
            line.setLength(6);

            // Second output
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}
