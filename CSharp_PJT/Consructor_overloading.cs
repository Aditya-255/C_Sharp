using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class Consructor_overloading
    {
        class Employee {
            int eid;
            string name;
            string city;

            public Employee()
            {

            }
            public Employee(int eid, string name)
            {
                this.eid = eid;
                this.name = name;   
            }
            public Employee(int eid, string name, string city) : this(eid, name)
            {
                this.city = city;
            }
            public void display()
            {
                Console.WriteLine($"the employee id is {eid} and name is  {name} and city is {city}");
            }
        }
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp2 = new Employee(1,"abc","rajkot");
            emp2.display();
        }

    }
}
