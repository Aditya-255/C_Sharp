using System;


namespace Aditya_Dodiya_23SOECE11014
{
    class Q5
    {
        public static void Main(string[] args)
        {
            int n, fact = 1; //Declaring integer variables: n for input, fact initialized to 1
            Console.WriteLine("Enter a number to find its factorial: ");
            string str = Console.ReadLine(); //Reading input from the user
            n=Convert.ToInt32(str); //Converting the input string to an integer
            for(int i=1;i<=n;i++) // Loop from 1 to n to calculate factorial
            {
                fact = fact * i; // Multiply fact with current value of i
            }
            Console.WriteLine("Factorial is: " + fact); //Outputting the factorial result
        }
    }
}
