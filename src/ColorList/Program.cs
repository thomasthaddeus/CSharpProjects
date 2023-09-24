/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE10 EX02
** Date: 2021 - 12 - 12
** Description:
** Create a generic List then use the native methods to add and remove variables
** then check your list
********/

using System.Collections.Generic;
using static System.Console;

namespace ColorList
{
    internal class Program
    {
        private static void Main()
        {
            List<string> Colors = new List<string>();
            AddColors(Colors); //initializes the List collection
            Colors.ForEach(Print);
            SortColors(Colors); //Alphabetizes and indexs the list
            RemoveColors(Colors); //outputs violet being replaced
            ShowColors(Colors); //Method for printing the current list
            ReadLine();
            NewColor(Colors); //Tests for a new color and outputs the results
            NewColor(Colors);
            ReadLine();
        }

        public static void AddColors(List<string> Colors)
        {
            Colors.AddRange(new List<string> { "White", "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "Black" });
        }

        public static void SortColors(List<string> Colors) //counts and sorts the colors list
        {
            int count = Colors.Count;
            Write($"\nThe Colors List has {count} items.\n");
            ReadLine();
            Colors.Sort(); //alphabetizes list
            Write("New sorted list is:\n\n");
            ShowColors(Colors);
            ReadLine();
        }

        public static void RemoveColors(List<string> Colors)
        {
            int count = Colors.Count;
            int IndexViolet = Colors.IndexOf("Violet"); //Finds violet then removes it from the list
            Colors.RemoveAt(IndexViolet);
            Colors.Insert(count - 2, "Purple"); //inserts in the second to last location
            WriteLine("\n\nPurple has replaced Violet\n");
        }

        private static void ShowColors(List<string> Colors)
        {
            foreach (string color in Colors) //reprints list using the ShowColors Method
            {
                Print(color);
            }
        }

        private static void NewColor(List<string> Colors) //adds a new color to the list
        {
            if (Colors.Contains("Magenta"))
            {
                WriteLine("Magenta is in the list\n");
                Colors.ForEach(Print);
                Write("\n\n\n");
            }
            else
            {
                WriteLine("\n\nMagenta is absent\n");
                Colors.Add("Magenta");
            }
        }

        private static void Print(string s)
        {
            Write(s + ", ");
        }
    }
}