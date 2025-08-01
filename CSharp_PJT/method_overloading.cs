using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class method_overloading
    {
        class student {
            public void detail(int sid, string name) {
                Console.WriteLine(sid+" " + name);
            }
            public void detail(string name) {
                Console.WriteLine(name);
            }

            public void detail(int sid, string name, string fullname) {
                Console.WriteLine($"{sid} {name} {fullname}");
            }
        }

        public static void Main(string[] args)
        {
            student s = new student();
            s.detail(1, "abc");
            s.detail("efg");
            s.detail(1, "hinkj", "jvbsvbuy bhjb");
        }
    }
}
