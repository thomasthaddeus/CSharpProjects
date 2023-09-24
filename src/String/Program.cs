/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP06 String
** Date: 2021 - 11 - 10
** Description: Parse the even letters from a string 
**
********/

using static System.Console;
using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS132";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i++)
            { 
                if (i % 2 == 0)
                {
                   Write(message[i]); //output is every other letter from message
                } 
            }
        }
    }
}
