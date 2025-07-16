using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aditya_Dodiya_23SOECE11014.Tutorial_02
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 5, 5 };

            bool[] vis=new bool[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                if(vis[i])
                {
                    continue;
                }
                int c = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        vis[j] = true;
                        c++;
                    } 
                }
                Console.WriteLine("Frequency of {0} is {1} ", arr[i], c);
            }
        }
    }
}
