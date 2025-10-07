using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    abstract class X
    {
        protected int n1, n2;
        public X(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public void add(int n1,int n2)
        {
            Console.WriteLine($"Addition: {n1 + n2}");
        }
        public abstract void mul(int n1, int n2);
    }
    internal class Abs
    {
        public static void Main(string[] args)
        {
            X obj = new Y(10, 20);
            obj.add(10, 20);
            obj.mul(10, 20);
        }
    }
}
