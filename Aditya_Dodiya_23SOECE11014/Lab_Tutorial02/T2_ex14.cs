using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    internal class T2_ex14
    {
        static void Main()
        {
            Console.Write("Input the marks obtained in Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            int totalAll = maths + physics + chemistry;
            int totalMathsPhysics = maths + physics;

            bool isEligible = (maths >= 65 && physics >= 55 && chemistry >= 50) &&
                              (totalAll >= 180 || totalMathsPhysics >= 140);

            if (isEligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
