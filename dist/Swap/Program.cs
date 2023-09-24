/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE10 EX01
** Date: 2021 - 12 - 12
** Description: 
** Use generics to swap the values of variables using a temporary variable
**
********/

using System;
using static System.Console;

namespace ExerciseSwap
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            WriteLine(a + ", " + b); //output values

            T temp = a; //Temporary variable used as a placeholder
            a = b;
            b = temp;

            //show values as swapped
            WriteLine(a + ", " + b);
        }

        public static void Main()
        {
            int a1 = 1, a2 = 2;
            string b1 = "Mark", b2 = "John";

            Swap<int>(ref a1, ref a2); 
            Swap<string>(ref b1, ref b2);
        }
    }
}
