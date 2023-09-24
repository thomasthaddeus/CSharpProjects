/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP01
** Date: 2021 - 10 - 08
** Description: Introduction to C# Coding
** Hello world file working on naming variables. 
**
********/

using System;
using static System.Console;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Thad";
            int Age = 32;
            bool isFemale = false;
            double MyFloat = 10.1;

            WriteLine(Name);
            WriteLine(Age);
            WriteLine(isFemale);
            WriteLine(MyFloat);
        }
    }
}