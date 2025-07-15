using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PJT
{
    internal class Tutorial_ex
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input the number of terms: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number: ");
            int a=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = a;
            for(int i=1; i <= x; i++)
            {
                Console.Write($"{temp} + ");
                sum += temp;
                temp = temp * 10+a;
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
