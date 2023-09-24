/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE06 Exercise04
** Date: 2021 - 11 - 12
** Description: Modification from original Expressions Program
** Change the code in Main so that the variables 'a' and 'b' are intialized by user input
** Use Convert.ToInt32() to change the user input values from string to integer before using them as parameter arguments
**
********/

using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; 
            int b;
            Console.WriteLine("Input a,b to see addition, subtraction, division, multiplication, and a remainder operations\n" +
                "Input a value between 20 - 100 for A\n" +
                "Then press enter");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a value for B\n" +
                                "Then hit enter.");
            b = Convert.ToInt32(Console.ReadLine());

            //multiply, divide, add, subtract, and modulus(the remainder operator)
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
        }
    }
}
