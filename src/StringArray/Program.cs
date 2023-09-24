/********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE02_Ex02 StringArray
** Date: 2021-10-17
** Description: Make a list of 4 things and ahave the program list them onscreen while it waits for feedback to end it
** Declares and sorts the array after which it will output the array values 
**
********/

using System;
using static System.Console; //now i don't have to write Console in front of WriteLine

namespace StringArray
{
    class Program
    {
        enum FinalFourTeam { Baylor = 1, Gonzaga, UCLA, Houston } //Assign the first string a value and its +1 from there
        static void Main(string[] args) //saves lines so i can call all strings at once when i enumerate
        {
            FinalFourTeam myFourTeam = FinalFourTeam.Gonzaga;
            WriteLine("My pick for the Final Four was");
            WriteLine(myFourTeam);
            WriteLine("The other teams were: ");
            WriteLine(FinalFourTeam.Baylor);
            WriteLine(FinalFourTeam.UCLA);
            WriteLine(FinalFourTeam.Houston); //I could not figure this out so i took the worst way possible and went to writing it out exactly

            int numFourTeam = (int)FinalFourTeam.Baylor; //Declaring the variable
            WriteLine(
                "Baylor finished the Final Four as #: {0:G}\n", numFourTeam);
        }
    }
}