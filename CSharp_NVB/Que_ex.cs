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
        string instName;
        int basicpay;

        public int ECODE
        {
            get;
            set;
        }


        Employee11(int ecode,string name,string designation,string instName,int basicpay)
        {

        }

    }
    internal class Que_ex
    {
        public static void Main(string[] args)
        {
            Employee11 employee11 = new Employee11(1, "rushi", "HR", "RK", 10);

        }
    }
}
