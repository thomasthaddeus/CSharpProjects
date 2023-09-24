/*******************************************************************************
**
** Name: Password Checker
** Written By: Thaddeus Thomas
** Date: 9/12/2022 
** Purpose:
**   Checks that the length of a password is at least 12
**   Then it scores the input based on Unique characters used
**   whether they used upper or lower case and numbers and special characters
**
********************************************************************************/

using System.Threading.Tasks.Sources;
using static System.Console;

namespace PasswordChecker
{
    class Program
    {
        public static void Main()
        {
            //ask user for input
            WriteLine("Please enter a password: ");
            string passwd = ReadLine();

            int minLength = 4;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*?><,.+=-_";

            int len = passwd.Length;
            bool toolU = Tools.Contains(passwd, upperCase);
            bool toolL = Tools.Contains(passwd, lowerCase);
            bool toolCh = Tools.Contains(passwd, specialChars);
            bool toolD = Tools.Contains(passwd, digits);

            // score the users input
            int score = 0;

            if (len >= minLength)   { score += 1; }
            if (toolU == true)      { score += 1; }
            if (toolL == true)      { score += 1; }
            if (toolCh == true)     { score += 1; }
            if (toolD == true)      { score += 1; }

            //tell the user their score
            WriteLine($"Your password strength score is: {score}");

            //Print the users password score
            switch (score)
            {
                case 0:
                    WriteLine("The password doesnt meet any of the standards of a strong password");
                    break;
                case 1:
                    WriteLine("The password is weak");
                    break;
                case 2:
                    WriteLine("The password is medium strength");
                    break;
                case 3:
                    WriteLine("The password is strong");
                    break;
                case 4:
                    WriteLine("The password is extremely strong");
                    break;
                case 5:
                    WriteLine("The password is extremely strong");
                    break;
                default:
                    break;
            }
        }
    }
}
