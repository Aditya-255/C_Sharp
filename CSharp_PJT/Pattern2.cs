﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//*
//**
//***
//****
//*****
namespace CSharp_PJT
{
    internal class Pattern2
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <= 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
