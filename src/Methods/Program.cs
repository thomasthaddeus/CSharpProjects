/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP04 - Challenge 1
** Date: 2021 - 10 - 28
** Description: Learn how to call a method
** Expected return is 7
**
********/

using System;
using static System.Console;

namespace Methods
{
    class Program
    {
        public static int Mod(int a, int b)
        {
            int modulus = a % b; //write the formula for finding modulus of the variables
            return modulus;
        }
        
        static void Main(string[] args)
        {
            WriteLine(Mod(20, 13)); //plug in numbers to be printed
        }
    }
}
