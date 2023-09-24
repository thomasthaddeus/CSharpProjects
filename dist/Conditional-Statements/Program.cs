/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP05 EX01
** Date: 2021 - 11 - 07
** Description: Conditional Statements
** Learning how to use "if" and "and" statements
**
********/

using System;
using static System.Console;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            
            WriteLine("Guess a number (1 - 10): ");
            int userInput = Convert.ToInt32(ReadLine());

            if (userInput == num)
            {
                WriteLine("Your guess was correct!");
            }
            else if (userInput >= num)
            {
                WriteLine("Number must be between 1-10!!!");
            }
            else if (userInput != num)
            {
                WriteLine("You guessed wrong. Good luck next time!");
            }

        }
    }
}
