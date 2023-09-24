/********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: Module 5 | Exercise 3 | String Loop
** Date: 2021-11-05
** Description: 
** Use a for loop to iterate through all elements of a string array and print them to the console
**
********/

using System;
using static System.Console;

namespace String_Loop
{
    class Program
    {
        static void Main()
        {
            string[] soda = new string[] { "Coke", "Pepsi", "Mountain Dew", "Sprite" };
            for (int i = 0; i < soda.Length; i++)
            {
                WriteLine("Soda brand [" + i + "] = " + soda[i]);
            }
            ReadLine();
        }
    }
}
