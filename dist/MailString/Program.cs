/********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE06 Exercise 2 MailString
** Date: 2021 - 11 - 11
** Description: 
**     Define a method that takes two string arguments “firstname” and “lastname” as inputs.
** In the method body, use string concatenation and the substring method to create a new string to represent an email address. 
** Use the first character of the first name, the first three characters of the last name, and the literal string “@abc.com” to build the new string, all lower case.
** Return the string value to the client code that called the method and print out the value from the client code.
** Call the method three times from Main, passing different values each time, and inspect the results. 
**
********/

using System;
using static System.Console;

namespace MailString
{
    class Program
    {
        static void Main()
        {
            //string inputs for email addresses
            WriteLine(MyEmail("Alfie", "Allen")); 
            WriteLine(MyEmail("Bruce", "Bunce"));
            WriteLine(MyEmail("Charles", "Charge"));
        }    

        static string MyEmail(string firstName, string lastName)
        {
            return(firstName.Substring(0, 1) + lastName.Substring(0, 3) + "@abc.com").ToLower(); //lowercase and defining the index of letters to be used
        }
    }
}
