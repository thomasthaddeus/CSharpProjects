/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE04 - EX02
** Date: 2021 - 10 - 30
** Description: Passing arguments by reference
** explicitly passing the values across 2 methods
** verify with a screenshot that the values changed
**
********/

using System;
using static System.Console;

namespace RefVal{
    class Program{
        static void Main(){
            float house = 200000.0f;
            float salary = 75000.0f;

            //Explicitly pass variables by reference
            AdjustForInflation(ref house, ref salary);
            WriteLine("** Values After Inflation Adjustment **");
            WriteLine("Home: " + house);
            WriteLine("Income: " + salary);
            ReadLine();
        }
        
        // Receive arguments explicitly by reference
        static void AdjustForInflation(ref float home, ref float income){
            const float RATE = 1.03f;
            home   *= RATE;
            income *= RATE;
        
        }
    }
}
