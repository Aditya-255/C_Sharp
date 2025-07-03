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
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = 5 - 1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
