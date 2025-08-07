using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    class Student
    {

        private string name;
        //using methods
        public string getname()
        {
            return name;
        }
        public void setname(string fname)
        {
            this.name=fname;
        }
        //using properties
        //properties is use to access peivate members
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Properties
    {
        public static void Main()
        {
            Student obj = new Student();
            obj.setname("ABC");
            Console.WriteLine(obj.getname());

            obj.Name = "ABC";
            Console.WriteLine(obj.Name);

        }
    }
}
