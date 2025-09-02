using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    public class Student15 {
        int rno;
        string name;
        string branch;
        static int sem = 5;
        int s1, s2, s3;
        double avg;
        public Student15(int rno, string name, string branch, int s1, int s2, int s3)
        {
            this.rno = rno;
            this.name = name;
            this.branch = branch;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public void calcavg()
        {
            avg = (s1 + s2 + s3) / 3.0;
        }
        public double Avg
        { 
            get { return avg; }
        }
        public void showde()
        {
            Console.WriteLine("roll no: " + rno);
            Console.WriteLine("name is :" + name);
            Console.WriteLine("branch is: "+branch);
            Console.WriteLine("semester is: " + sem);
            Console.WriteLine("avg is : "+avg);
        }
    }

    internal class Ex
    {
        public static void Main(string[] args)
        {
            Student15 s15 = new Student15(1, "Rushi" , "ce", 90, 85, 45); 
            s15.calcavg();
            Student15 s25 = new Student15(1, "krsih", "ceA", 91, 83, 44);
            s25.calcavg();
            if (s15.Avg > s25.Avg)
            {
                s15.showde();
            }
            else {
                s25.showde();
            }
        }
    }
}
