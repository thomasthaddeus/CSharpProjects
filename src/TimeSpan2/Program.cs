/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP05 Ex02
** Date: 2021 - 11 - 17
** Description: A comparison of programming and testing time
**      to determine which takes longer during the week
**      the output is respresented by Total Development Time
**
********/

using System;
using static System.Console;

namespace TimeSpan2
{
    class Program
    {
        static void Main()
        {
            const int DAY = 0, HRS_A = 11, HRS_B = 9, MIN = 30, SEC = 10;
            TimeSpan proTime = new TimeSpan(DAY, HRS_A, MIN, SEC); //Total time spent Programming
            TimeSpan testTime = new TimeSpan(DAY, HRS_B, MIN, SEC); //Total time spent Testing
            TimeSpan TotalDevelopment = proTime.Add(testTime); //Total hours
            WriteLine(proTime.Days + " days " + proTime.Hours + " hours = Programming Time\n"
                + testTime.Days + " days " + testTime.Hours + " hours = Testing Time\n");
            WriteLine("Total Development Time = " + TotalDevelopment);
            
            //Compares which is longer and outputs the total of programming, testing, or 1/2 of the total
            int tD = proTime.CompareTo(testTime); 
            if (tD > 0)
                WriteLine("Programming time was longer this week @ " + proTime);
            else if (tD < 0)
                WriteLine("Testing consumed more time this week @ " + testTime);
            else
                WriteLine("They used the same amount of time @ " + TotalDevelopment / 2);

            ReadLine();
        }
    }
}
