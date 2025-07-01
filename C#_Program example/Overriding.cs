using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    internal class Overriding:Override
    {
        public float Calcbill(int amt)
        {
            return amt+(amt*0.18F);
        }
        public static void Main()
        {
            Override obj = new Overriding();
            Console.WriteLine("Bill amount is {0}", obj.Calcbill(1000));
            Console.ReadLine();
        }
    }
}
