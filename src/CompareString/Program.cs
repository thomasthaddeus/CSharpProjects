/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE06 Exercise03 CompareString
** Date: 2021 - 11 - 11
** Description: Use ToLower to change the case sensitivity when comparing strings
**
********/

using static System.Console;

namespace CompareString
{
    class Program
    {
        static void Main()
        {
            Write(Grade("Alpha", "aLPha"));
            WriteLine(" These are the same words");
            Write(Grade("letter", "LEtEr"));
            WriteLine(" These are not the same words");
        }

        static bool Grade(string letter, string input)
        {
            return letter.ToLower().Equals(input.ToLower());
        }
    }
}
