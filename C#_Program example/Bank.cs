using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    abstract class Bank
    {
        abstract public void Credit();
        abstract public void Debit();
        void display()
        {
            Console.WriteLine("This is a bank class");
        }
    }
}
