/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP05 Ex02
** Date: 2021 - 11
** Description: 
** 
**
********/

using System;
using static System.Console;

namespace While_Loop
{
    class Program
    {
        static void Main()
        {
            int num = 1;

            WriteLine("Guess a number (1 - 10): ");
            int userInput = Convert.ToInt32(ReadLine()); // receive user input and store in user variable

            while (true)
            {
                if (userInput > 0 && userInput <= 10)
                {
                    if (userInput == num)
                    {
                        WriteLine("Your guess was corrrect!");
                        break;
                    }
                    else
                    {
                        WriteLine("You guessed wrong. Guess again: ");
                        userInput = Convert.ToInt32(ReadLine());
                    }
                }
                else if (userInput >= 0 !| userInput <= 10)
                {
                    WriteLine("Number must be between 1 - 10, guess again: ");
                    userInput = Convert.ToInt32(ReadLine());
                }
            }
        }
    }
}