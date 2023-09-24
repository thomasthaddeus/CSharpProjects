/*********************
** 
** This program does the following:
** Runs the mad libs story      
** Author: Thaddeus Thomas
** Date 9/11/2022
** 
**********************/

using static System.Console;


namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            */

            // Let the user know that the program is starting:
            WriteLine("Mad Libs is starting!");

            // Give the Mad Lib a title:
            string title = "Mad Libs";
            WriteLine(title);
            
            // Define user input and variables:
            Write("Enter a name for the main character: ");
            string name = ReadLine();

            //----------adjectives----------------
            Write("Enter an adjective: ");
            string adj1 = ReadLine();

            Write("Enter another adjective: ");
            string adj2 = ReadLine();

            Write("Enter one more adjective: ");
            string adj3 = ReadLine();

            //------------verb--------------
            Write("Enter a verb: ");
            string verb = ReadLine();

            //-------------nouns--------------
            Write("Enter a noun: ");
            string noun1 = ReadLine();

            Write("Enter a 2nd noun: ");
            string noun2 = ReadLine();

            //-----------animal-------------
            Write("Enter an animal: ");
            string animal = ReadLine();

            //-----------food---------------
            Write("Enter a food: ");
            string food = ReadLine();

            //----------fruit---------------
            Write("Enter a fruit: ");
            string fruit = ReadLine();

            //--------superhero-------------
            Write("Enter a superhero: ");
            string superhero = ReadLine();

            //----------country--------------
            Write("Enter a country: ");
            string country = ReadLine();

            //----------dessert--------------
            Write("Enter a dessert: ");
            string dessert = ReadLine();

            //-----------year------------------
            Write("Enter a year: ");
            string yr = ReadLine();

            // The template for the story:
            string story = ($"This morning {name} woke up feeling {adj1}." +
                            $" 'It is going to be a {adj2} day!'" +
                            $" Outside, a bunch of {animal}s were protesting to keep {food} in stores." +
                            $" They began to {verb} to the rhythm of the {noun1}," +
                            $" which made all the {fruit}s very {adj3}." +
                            $" Concerned, {name} texted {superhero}," +
                            $" who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}." +
                            $" {name} woke up in the year {yr}," +
                            $" in a world where {noun2}s ruled the world.");

            // Print the story:
            WriteLine(story);
        }
    }
}

