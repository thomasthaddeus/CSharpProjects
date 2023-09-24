/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE07 EX03
** Date: 2021 - 11 - 18
** Description: A program for displaying numerous ways to write out dates
** shows many but not all 
**
********/

using System;
using static System.Console;

namespace Birthday
{
    class Program
    {
        static void Main()
        {
            const int YR = 1989, MTH = 4, DAY = 25, HRS = 15, MIN = 43, SEC = 22;
            DateTime birthday = new DateTime(YR, MTH, DAY, HRS, MIN, SEC);
            ShowDateTime(birthday);
            ReadLine();
            WriteLine("My birthday in the long format: \n"
                + birthday.ToString("D") //Long date format which includes commas
                + "\n\n My birthday in the universal full date/time: \n"
                + birthday.ToString("U")    //Universal date format
                + "\n\n Lastly long date/time: \n"
                + birthday.ToString("F"));
        }

        static void ShowDateTime(DateTime dt)
        {
            WriteLine("Year: " + dt.Year
                + " Month: " + dt.Month //output is April, May, June etc...
                + " Day: " + dt.Day
                + "\nDayOfWeek: " + dt.DayOfWeek  //outputs Monday, Tuesday etc...
                + "| DayOfYear " + dt.DayOfYear   // output is an integer of 365 or 366 depending on year
                + "| Hours: " + dt.Hour
                + "| Minutes: " + dt.Minute
                + "| Seconds: " + dt.Second);
        }
    }
}








/*
const int DAY = 6, HRS = 12, MIN = 18, SEC = 36;
TimeSpan span = new TimeSpan(DAY, HRS, MIN, SEC);
WriteLine(span.Days + " days \n"
    + span.Hours + " hours \n"
    + span.Minutes + " minutes \n"
    + span.Seconds + " seconds "); Console.WriteLine("Hello World!");
*/

