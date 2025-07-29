using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


/*
 Encapsulation :bind your data together,data hiding
        members=>not accessible from outside
        by defualt all members are private
inheritance:
Abstraction :providing functionalities to the users and hiding internal detail
       abstract keyword,interface
polymorphism : one form to multiple form



class:states: and behaviors:perform by object

1.Fan:wires,capaciters,name
2.bank:name,branch,
3.
 */
namespace CSharp_NVB

{
    public class Employee
    {
        int eid;
        string ename;
        double salary;
        public void getdata(int eid,string ename,double salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary =salary;

        }
        public void setdata()
        {
            Console.WriteLine("emp id:" + eid);
            Console.WriteLine("emp name:" + ename);
            Console.WriteLine("emp salary:" + salary);
        }
        public double getsalary()
        {
            return salary;
        }


    }
    public class Date_Time {
        int h;
        int m;
        int s;
        public void getTime(int h,int m,int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        public void setTime()
        {
            Console.WriteLine(h+" :"+m+" :"+s);
        }
    }

    internal class Oop
    {
        public static void Main(String[] args)
        {

            Employee e1 = new Employee();
            e1.getdata(2,"abcd",20000);
            //e1.setdata();

            Employee e2 = new Employee();
            e2.getdata(5, "efgh", 25000);
            //e2.setdata();
            if (e1.getsalary() > e2.getsalary())
            {
                e1.setdata();
            }
            else
            {
                e2.setdata();
            }
            Date_Time dt = new Date_Time();
            dt.getTime(11, 34, 55);
            dt.setTime();
        }
        
    }
}
