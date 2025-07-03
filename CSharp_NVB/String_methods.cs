using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class String_methods
    {
        public static void Main(string[] args)
        {
            // String methods
            string str = "Hello World";
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            Console.WriteLine("Original String: " + str);
            // Length
            Console.WriteLine("Length: " + str.Length);
            // ToUpper
            Console.WriteLine("ToUpper: " + str.ToUpper());
            // ToLower
            Console.WriteLine("ToLower: " + str.ToLower());
            //combine or concate two strings
            str3 = str1 + " " + str2;
            Console.WriteLine("Combine string is:" + str3);

            //using concat
            str3 = string.Concat(str1, " ", str2);
            Console.WriteLine("Combine string using concat:" + str3);

            //interpolation of string
            int no = 100;
            str3 = $"Multiplication of number is:{no * 10}";
            Console.WriteLine("String 3 is:" + str3);
            // Substring
            Console.WriteLine("Substring(0, 5): " + str.Substring(0, 5));
            // IndexOf
            Console.WriteLine("IndexOf('World'): " + str.IndexOf("World"));
            // Replace
            Console.WriteLine("Replace('World', 'CSharp'): " + str.Replace("World", "CSharp"));
            // Split
            string[] words = str.Split(' ');
            Console.WriteLine("Split: " + string.Join(", ", words));
            // Trim
            string paddedStr = "   Hello World   ";
            Console.WriteLine("Trim: '" + paddedStr.Trim() + "'");
        }
    }
}
