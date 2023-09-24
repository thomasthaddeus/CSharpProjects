/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE05 | Ex04 | 
** Date: 2021 - 11 - 7
** Description: Showing how to use a while loop 
** to write conditional statements
** Exercise 04: Use a while loop to call a method, and then prompt 
** the user for input whether to continue the loop or quit
**
********/

using System;
using static System.Console;

namespace GoOrQuit
{
    class Program
    {
        static void Main()
        {
            bool readInput = true;
            while (readInput)//what will happen as long as the while is true 
            {
                ShowMenu();
                string option = ReadLine(); //User input 
                if (option == "2")
                    break;
                else
                {
                    WriteLine("Keep Going it is.");
                    WriteLine("");
                }
            }
            WriteLine("I guess we're ending");
            ReadLine();
        }

        static void ShowMenu()
        {
            WriteLine("** Menu **");
            WriteLine("1. Keep running this program. ");
            WriteLine("2. End.");
        }
    }
}
