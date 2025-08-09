using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex13
    {
        static void Main()
        {
            int[] denominations = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] noteCount = new int[denominations.Length];

            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < denominations.Length; i++)
            {
                if (amount >= denominations[i])
                {
                    noteCount[i] = amount / denominations[i];
                    amount = amount % denominations[i];
                }
            }

            for (int i = 0; i < denominations.Length; i++)
            {
                Console.WriteLine("Notes of Rs.{0} = {1}", denominations[i], noteCount[i]);
            }
        }
    }
}
