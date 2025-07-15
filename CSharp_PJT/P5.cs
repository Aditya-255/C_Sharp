using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*
//**
//***
//****
//*****
//****
//***
//**
//*
namespace CSharp_PJT
{
    internal class P5
    {
        public static void Main(string[] args)
        {
            ////uisng 2 loops
            //for (int i = 1; i <= 5; i++)
            //{5
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //using single loop
            for (int i = 1; i <= 9; i++)
            {
                int k = i <= 5 ? i : 10 - i;
                for (int j = 1; j <= k; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
}
