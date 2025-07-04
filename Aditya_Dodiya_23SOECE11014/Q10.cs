using System;
namespace Aditya_Dodiya_23SOECE11014
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            string input = Console.ReadLine();
            string marked = input.Substring(0, input.Length - 5) + new string('X', 5);
            Console.WriteLine("Masked Number: " + marked);
        }
    }
}
