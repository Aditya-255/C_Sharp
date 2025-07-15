using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NVB
{
    internal class max_ele_in_array
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            bool[] arr2 = new bool[5];
            for(int i=0; i < arr2.Length; i++)
            {
                arr2[i] = false;
            }
            foreach (int i in arr)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr2[2] == true)
                {
                    continue;
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr2[i] = true;
                        c++;
                    }
                }
                Console.WriteLine("Frequnecy of {0} and {1} time", arr[i],c);
            }
        }
    }
}
