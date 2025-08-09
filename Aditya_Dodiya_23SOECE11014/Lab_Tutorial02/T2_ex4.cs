using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex4
    {
        public static void Main()
        {
            Console.Write("Enter number A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Enter number B: ");
            int B = int.Parse(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operations ---");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {(float)A / B}"); // float division
            Console.WriteLine($"A % B = {A % B}");

            // Relational Operators
            Console.WriteLine("\n--- Relational Operations ---");
            Console.WriteLine($"A == B: {A == B}");
            Console.WriteLine($"A != B: {A != B}");
            Console.WriteLine($"A > B: {A > B}");
            Console.WriteLine($"A < B: {A < B}");
            Console.WriteLine($"A >= B: {A >= B}");
            Console.WriteLine($"A <= B: {A <= B}");

            // Logical Operators (example using conditions)
            Console.WriteLine("\n--- Logical Operations ---");
            Console.WriteLine($"(A > 0 && B > 0): {(A > 0 && B > 0)}");
            Console.WriteLine($"(A > 0 || B > 0): {(A > 0 || B > 0)}");
            Console.WriteLine($"!(A > 0): {!(A > 0)}");

            // Bitwise Operators
            Console.WriteLine("\n--- Bitwise Operations ---");
            Console.WriteLine($"A & B = {A & B}");
            Console.WriteLine($"A | B = {A | B}");
            Console.WriteLine($"A ^ B = {A ^ B}");
            Console.WriteLine($"~A = {~A}");
            Console.WriteLine($"A << 1 = {A << 1}");
            Console.WriteLine($"B >> 1 = {B >> 1}");

            // Assignment Operators
            Console.WriteLine("\n--- Assignment Operations ---");
            int C = A;
            C += B;
            Console.WriteLine($"C += B: {C}");
            C -= B;
            Console.WriteLine($"C -= B: {C}");
            C *= B;
            Console.WriteLine($"C *= B: {C}");
            C /= B;
            Console.WriteLine($"C /= B: {C}");
        }
    }
}
