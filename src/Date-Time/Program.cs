/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP07
** Date: 2021 - 11 - 15
** Description: using the key Date Time functions to show what month and what day of the month
**
********/

using System;
using static System.Console;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {           
            DateTime dateTime = DateTime.Now;
            int month = Convert.ToInt32(DateTime.UtcNow.ToString("MM"));  //Month must be integer and not named
            int year = Convert.ToInt32(DateTime.UtcNow.ToString("yyyy"));
            int days = DateTime.DaysInMonth(year, month);
            WriteLine("{0}\n", dateTime.ToString("MM")); //displays the current 2 digit month
            WriteLine("{0}", days); //displays the total number of days in the current month
        }
    }
}