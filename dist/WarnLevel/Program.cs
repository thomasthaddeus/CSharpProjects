/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE05
** Date: 2021 - 11 - 01
** Description:  
** 1. Define a method that takes one integer input argument.
** 2. Inside the method body create an if…else statement that defines three different warning messages, and a fourth default message.
** 3. Inside Main call the method several times to test all the code paths in the if – else statement.
** 4. Code example: 5-1 if…else Statements
**
********/

using System;
using static System.Console;

namespace WarnLevel02 {
    class Program {
        const bool WINDY = true;
        const int INACTIVE = -1;
        const int TropicalStorm = 0, Cat1 = 1, Cat2 = 2, Cat3 = 3;

        public static void Main() {
            int intensity = INACTIVE; 
            ShowWarning(intensity); // Call ShowWarning() method.
            intensity     = Cat3;
            ShowWarning(intensity); // Call ShowWarning() method
            intensity     = Cat2;
            ShowWarning(intensity); // Call ShowWarning() method
            intensity     = Cat1;
            ShowWarning(intensity); // Call ShowWarning() method
            intensity     = TropicalStorm;
            ShowWarning(intensity); // Call ShowWarning() method
            ReadLine();
        }

        // Show warnings based on hurricane intensity.
        public static void ShowWarning(int intensity) {
            if (intensity == Cat3) {
                WriteLine("Category 3+: Devastating damage will occur.");
            }
            else if (intensity == Cat2) {
                WriteLine("Category 2: Extremely dangerous winds will cause extensive damage");
            }
            else if (intensity == Cat1) {
                WriteLine("Category 1: Very dangerous winds will produce some damage.");
            }
            else if (intensity == TropicalStorm) {
                WriteLine("Tropical Storm: High winds, flooding possible");
            }
            else {
                WriteLine("Inactive: No damage expected.");
            }
        }
    }
}