using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    internal class Pattern5
    {
        public static void Main(string[] args)
        {
            ////uisng 2 loops
            //for (int i = 1; i <= 5; i++)
            //{
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
                int k =1;
                for(int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                    k++;
                    if (k > 5)
                    {
                        k--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
