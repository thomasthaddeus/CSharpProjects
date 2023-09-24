/********
**
** Name: Thad Thomas
** Class: CS132
** Project: PE02 ex. 01
** Date: 2021-10-17
** Description: Declare and initialize 4 different types of variables.
** Integer, Float, String, and casting the float value to integer
** WriteLine is to confirm the values output correctly
**
********/

using System;

namespace Starter
{
    class Program
    {
        public static void Main()
       {
            // Variable declarations and initialization (assignment). 
            int normalStow = 77;
            float  misStow = 22.25f;
            string perfectStow = "Stow 100.";
            int castStow = (int)misStow;
            
            
            // Display the variable values. 
            Console.WriteLine("Normal stow amount is " + normalStow);
            Console.WriteLine("Amount needed to reach benchmark " + misStow);
            Console.WriteLine("Benchmark value " + perfectStow);
            Console.WriteLine("Well be close to benchmark after " + castStow + " more." ); // adds the 22 and drops the .25 rounding due to it being a variable
            Console.ReadLine();
        }
    }
}