using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Program
{
    public class Program3
    {
        int id;
        string name;
        public void Accept(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("id is {0} and name is {1}", id, name);
        }
    }
}
