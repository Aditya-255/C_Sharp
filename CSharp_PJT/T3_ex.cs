using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class T3_ex
    {
        class Line

        {

            private double length;   // Length of a line

            public Line()

            {
                length = 10.0;
                Console.WriteLine("object being created. line no= "+ length );

            }



            public void setLength(double len)

            {

                this.length = len;     



            }

            public double getLength()

            {

                return length;     

            }

        }



        class TestLine

        {

            static void Main(string[] args)

            {

                Line line = new Line();

                line.setLength(10.00);

                Console.WriteLine("Length of line : {0}", line.getLength());

                line.setLength(6.00);

                Console.WriteLine("Length of line : {0}", line.getLength());

                //Console.ReadKey();

            }

        }

    }
}

