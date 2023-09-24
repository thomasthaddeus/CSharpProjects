/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE03 Ex1
** Date: 2021 - 10 - 08
** Description: 
** learn how to write math into the code so that the machine does the number crunching
**
********/

using System;
using static System.Console;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b= 20;

            //multiply, divide, add, subtract, and modulus(the remainder operator)
            WriteLine("{0} + {1} = {2}", a, b, a + b);
            WriteLine("{0} - {1} = {2}", a, b, a - b);
            WriteLine("{0} * {1} = {2}", a, b, a * b);
            WriteLine("{0} / {1} = {2}", a, b, a / b);
            WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}
