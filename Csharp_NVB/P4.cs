using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_NVB
{
    internal class P4
    {
        public static void Main(string[] args)
        {
            string str1, str2, str3;
            Console.WriteLine("enter the string 1:");
            str1=Console.ReadLine();
            Console.WriteLine("enter the string 2:");
            str2 = Console.ReadLine();
            Console.WriteLine("enter the string 3:");
            str3 = Console.ReadLine();
            int len=str1.Length;
            Console.WriteLine("len is " + len);
            int len2=str2.Length;
            Console.WriteLine("len is " + len2);
            int len3 = str3.Length;
            Console.WriteLine("len is " + len3);

            str3=str3.ToLower();
            Console.WriteLine("str3 is lower case "+str3);
            str2=str2.ToUpper();
            Console.WriteLine("str2 is upper case "+str2);

            // combine to string
            str1 = str2 + str3;
            Console.WriteLine("combine string is " + str1);
            str3=string.Concat(str1," ",str2);
            Console.WriteLine("combine two string using Concat " + str3);

            //interpolation in string
            int n = 100;
            str3 = $"muiltiplication of number: {n * 10}";
            Console.WriteLine(str3);

        }
    }
}
