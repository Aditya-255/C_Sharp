using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial03
{
    class Product
    {
        // Declare instance variables
        private string pcode;
        private string pname;
        private string mname;

        // Constructor to initialize product
        public Product(string pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Method to display product details
        public void Display()
        {
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }
    internal class T3_Q5
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                // Read input values from command line
                string pcd = args[0];
                string pnm = args[1];
                string mnm = args[2];

                // Create Product object with arguments
                Product p = new Product(pcd, pnm, mnm);
                p.Display();

                Console.Read(); // Keep console open
            }
        }
    }
}
