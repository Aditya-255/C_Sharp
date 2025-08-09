using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Lab_Tutorial02
{
    
    internal class T2_ex10
    {
        static int MatSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1; // Start from top-right corner

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                    return 1;
                else if (mat[i, j] > X)
                    j--; // Move left
                else
                    i++; // Move down
            }

            return 0; // Not found
        }
        public static void Main()
        {
            int N = 3; 
            int M = 3;
            int [,] mat = {
                  {3, 30, 38},
                  {44, 52, 54},
                  {57, 60, 69},
                };
            int X = 62;
            int ans=MatSearch(mat, N, M, X);
            Console.WriteLine(ans);
        }
    }
}
