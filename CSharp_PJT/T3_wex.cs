using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    class Student3
    {
        private int enrno;
        public int Enrno
        {
            get { return enrno;}
            set { enrno = value; }
        }
        private string name;
        public string Name
        {
            get{ return name;}
            set { name = value; }
        }
    }
    internal class T3_wex
    {
        public static void Main()
        {
            Student3 s3=new Student3();
            s3.Enrno = 1;
            s3.Name = "Rushi";
            
            string t=s3.Name;
            int t1 = s3.Enrno;
            Console.WriteLine("Enrollment no.: " + t);
            Console.WriteLine("Student name is : " + t1);
        }
    }
}
