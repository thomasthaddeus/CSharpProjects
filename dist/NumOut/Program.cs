/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE06 | Exercise 1 | NumOut
** Date: 2021 - 11 - 9
** Description: 
** Define a double variable with the value 987654.321d
** Use ToString parameters to display the variable three different ways: 
**      with two decimal points, as an integer, and as a currency value
**
********/

using System;
using static System.Console;

namespace NumOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 987654.321d;
            WriteLine(num.ToString(".00")); //Output to the hundreth decimal place
            WriteLine(num.ToString("0"));   //Output is an integer
            WriteLine(num.ToString("C"));   //Output is currency
        }
    }
}
