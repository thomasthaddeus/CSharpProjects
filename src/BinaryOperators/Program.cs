/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE03 | Ex 2
** Date: 2021 - 10 - 22
** Description: Using binary operators with different operators
** Add, subtract, divide, multiply, and remainder
** The Variable is going to have a running total
**
********/

using System;
using static System.Console;

namespace BinaryOperators
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 100, b = 20; //declare variables

            a += b; 
            WriteLine("The value of a is now:{0}", a); 

            a -= b;
            WriteLine("The value of a is now:{0}", a);

            a /= b;
            WriteLine("The value of a is now:{0}", a);

            a *= b;
            WriteLine("The value of a is now:{0}", a);

            a %= b;
            WriteLine("The value of a is now:{0}", a);
            // Print Output:
            // ( 120, 100, 5, 100, 0 )
        }
    }
}
