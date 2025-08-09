using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex9
    {
        static void FindTwoOddNumbers(int[] arr)
        {
            int xor = 0;

            foreach (int num in arr)
            {
                xor ^= num;
            }

            int setBit = xor & -xor;

            int num1 = 0, num2 = 0;


            foreach (int num in arr)
            {
                if ((num & setBit) != 0)
                    num1 ^= num;
                else
                    num2 ^= num;
            }

            if (num1 < num2)
                Console.WriteLine($"{num1} {num2}");
            else
                Console.WriteLine($"{num2} {num1}");
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 }; 
            FindTwoOddNumbers(arr);
        }
    }
}
