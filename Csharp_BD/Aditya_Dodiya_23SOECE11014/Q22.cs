using System;


namespace Aditya_Dodiya_23SOECE11014
{
    class Q22
    {
        public static void Main(string[] args)
        {
            int n = 8;
            for(int i=1;i<=n; i++)
            {
                Console.Write(new string(' ', (n/2) - i)); 
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    if(j < i)
                    {
                        Console.Write("*"); 
                    }
                }
                Console.WriteLine();
                if (i > 4)
                {
                    Console.Write(new string('*', (n / 2) - i));
                }
            }
        }
    }
}
