using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    public class Program4 : Program3
    {
            int salary;
            public  void Accept1(int salary)
            {
                this.salary = salary;
            }
            public void Display1()
            {
                Console.WriteLine("Salary is {0}", salary);
            }
            
    }
    }


