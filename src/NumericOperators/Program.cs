/********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: Module 3 | Challenge 1 | NumericOperators
** Date: 2021-10-21
** Description: 
** writing out pemdas for this System class
** 
**
********/
using System;
using static System.Console;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //list all the variables that are going to be used
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            //all the calculations to be made
            float sum = num1 + num2 + num3; //float so decimal isnt rounded off
            int subtract = num2 - num1; 
            int multiply = num1 * num2; 
            float divide = num1 / num3; //use the float call again otherwise the number will be rounded off
            int modulus = num2 % num1; //Gives the modulus i.e. remainder after dividing num2 by num1 

            //Calculations output to the Gui
            WriteLine("Sum of 3 number is: " + sum);
            WriteLine("77 - 20 is: " + subtract);
            WriteLine("20 * 77 is: " + multiply);
            WriteLine("20 / 5.2 is: " + divide);
            WriteLine("77 % 20 is: " + modulus);
        }
    }
}
