using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
public class Employee11
    {
        int ecode;
        string name;
        string designation;
        int basicpay;
        double da;
        double hra;
        double totalpay;
        public int ECODE
        {
            get;
            set;
        }


        public Employee11(int ecode,string name,string designation,int basicpay)
        {
            this.ecode = ecode;
            this.name = name;
            this.designation = designation;
            this.basicpay = basicpay;
        }
        public void calcDA()
        {
            da = 0.45 * basicpay;
        }
        public void calcHra()
        {
            hra = 0.2 * basicpay;
        }
        public void calctotal()
        {
            totalpay = basicpay + da + hra;
        }
        public void showdetails()
        {
            Console.WriteLine("total pay : "+totalpay);
        }
    }
    internal class Que_ex
    {
        public static void Main(string[] args)
        {
            Employee11 e11 = new Employee11(1, "rushi", "HR", 10);
            e11.calcDA();
            e11.calcHra();
            e11.calctotal();
            e11.showdetails();
        }
    }
}
