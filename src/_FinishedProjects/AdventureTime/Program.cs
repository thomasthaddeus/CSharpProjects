/*********************************************
* 
*  Author: Thaddeus Thomas
*  Date: 9/12/2022
*  Name: Choose Your Own Adventure | AdventureTime
*
*  Purpose: This program allows you to 
*           choose your own adventure 
*           based off boolean questions
*
*******************************************/

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main()
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            // Story begins
            Console.WriteLine("It begins on a cold rainy night.\n" +
                          " You're sitting in your room and hear a noise coming from down the hall.\n" +
                          " Do you go investigate?");
            // Decision 1
            Console.Write($"{name}, Type YES or NO\n");
            string noiseChoice = Console.ReadLine().ToUpper();

            if (noiseChoice == "NO")
            {
                // End of Story Way #1
                Console.WriteLine("Not much of an adventure if we don't leave our room!\n THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\n" +
                                  "You walk towards it. Do you open it or knock?");

                // Decision 2
                Console.Write("Type OPEN or KNOCK:\n");
                string doorChoice = Console.ReadLine().ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\r\n\"Poor people have it. Rich people need it. If you eat it you die.\n What is it?\"");
                    Console.Write("Type your answer:\n\t\t");
                    string riddleAnswer = Console.ReadLine().ToUpper();

                    // End of Story Way #2
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\r\nTHE END.");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine().ToUpper();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\r\nThe door opens and NOTHING is there. Strange...\r\nTHE END");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\r\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.\r\nTHE END.");
                            break;
                        // End of Story Way #3
                        default:
                            Console.WriteLine("You did not pick a key!\nTHE END");
                            break;
                    }
                }
            }
        }
    }
}