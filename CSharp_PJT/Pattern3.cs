using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*****
//****
//***
//**
//*
namespace CSharp_PJT
{
    internal class Pattern3
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
