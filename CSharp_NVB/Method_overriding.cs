using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * method overriding
 * 
 */
namespace CSharp_NVB
{
    class P {
        public virtual void show()
        {
            Console.WriteLine("parent class");
        }
    }
    class C : P
    {
        public override void show()
        {
            P obj = new P();
            base.show();
            Console.WriteLine("child class");
        }
    }
    internal class Method_overriding
    {
        public static void Main(string[] args)
        {
            P pobj;
            C cobj = new C();
            pobj = cobj;
            pobj.show();
            cobj.show();
        }
    }
}
