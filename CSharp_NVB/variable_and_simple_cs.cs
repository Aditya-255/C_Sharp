using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace net_nb
{
    internal class variable_and_simple_cs
    {
        public static void Main(string[] args)
        {
            int no = 15;
            double temp = 32.45;
            char gender = 'A';

            string name;
            name = "RKU";
            Console.WriteLine(name);
            Console.WriteLine("Number is :" + no);
            Console.WriteLine("Gender is :" + gender);
            Console.WriteLine("Temprature of room is :" + temp);

            string str;
            Console.WriteLine("Enter string value:");

            str = Console.ReadLine();
            Console.WriteLine("String is:" + str);

            int no1;
            int no2;
            Console.WriteLine("Enter two numbers no1 and no2: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("First number is:" + no1);
            Console.WriteLine("Second number is:" + no2);
        }
    }
}