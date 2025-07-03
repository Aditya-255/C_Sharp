using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class For_While_Loop
    {
        public static void Main(string[] args)
        {
            // WHILE LOOP
            // Print 1 to 10
            int no = 1;
            while (no <= 10)
            {
                Console.WriteLine(no);
                no++;
            }
            // PRINT 10 TO 1
            int n = 10;
            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }
            // FOR LOOP
            // PRINT 10 TO 1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            // PRINT 1 TO 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
