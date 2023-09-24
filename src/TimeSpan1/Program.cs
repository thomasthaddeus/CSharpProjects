/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE07 Ex01
** Date: 2021 - 11 - 17
** Description: The procrastination totals of my week
** Display day, hour, minutes and seconds as thez output
**
********/

using System;
using static System.Console;

namespace TimeSpan1
{
    class Program
    {
        static void Main()
        {
            const int DAY = 6, HRS = 12, MIN = 18, SEC = 36; //How much of the week has elapsed before I start programming
            TimeSpan span = new TimeSpan(DAY, HRS, MIN, SEC);
            WriteLine("The amount of time I spend procrastinating weekly: ");
            WriteLine(span.Days + " days\n" 
                + span.Hours + " hours\n"
                + span.Minutes + " minutes\n"
                + span.Seconds + " seconds");
        }
    }
}
