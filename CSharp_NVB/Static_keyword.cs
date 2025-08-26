using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*uses:
 * variable(data members)
 * methods
 * constructor
 * class 
 * static member
 * class Demo{
 * int x;
 * static int y;
 * }
 * here x is non static -> each object x has separate memory ,store different
 * values for each object
 * y is static-> whole class memory is allocated to y, can store common values for each
 * 
 */
//public class Demo7
//{
//    int x;
//    static int y;
//    Demo7(int x) {
//        this.x = x;
//        //this.y = y;    
//    }

//    public Demo7()
//    {

//    }

//    public static  int sum()
//    {
//        Demo7 ob = new Demo7();
//        return (ob.x+y);
//    }
//    public void show1()
//    {
//        Console.WriteLine(x);
//        Console.WriteLine(Demo7.y);
//    }
//}

public static class Demo11 {
    static int x = 10;
    static Demo11()
    {
        Console.WriteLine("calling Constructor:");
    } 
    public static void show11()
    {
        Console.WriteLine("x is a: "+x);
    }
}

namespace CSharp_NVB
{
    internal class Static_keyword
    {
        public static void Main()
        {
            //Demo7 demo7= new Demo7();
            //demo7.show1();
            Demo11.show11();
        }
    }
}
