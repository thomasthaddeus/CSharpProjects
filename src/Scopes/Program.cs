/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP04
** Date: 2021 - 10 - 28
** Description:  Learn how to use scopes when
** theyre part of your method and use them to call public methods
**
********/

using System;
using static System.Console;

namespace Scopes
{
    class Program
    {
        public static string Str2; //Global Variable

        static void ReturnString(string Str1)
        {
            Str2 = "Programming in C#";

            Write(Str1);
        }
        
        
        static void Main(string[] args)
        {
            ReturnString("CS132 "); //This looks a concat function 
            WriteLine(Str2); //I can Always call this because of it being public
        }
    }
}
