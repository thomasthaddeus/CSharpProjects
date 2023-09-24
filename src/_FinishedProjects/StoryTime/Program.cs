using static System.Console;

namespace StoryTime
{
    class Program
    {
        static void Main()
        {
            // Declare the variables
            const string beginning = "I woke up!";
            const string middle = "I went to work!";
            const string end = "I came home. The End!";

            // Concatenate the string and the variables
            const string story = beginning + " " + middle + " " + end;

            // Print the story to the console 
            WriteLine(story);

            // Declare the variables
            const string beginning2 = "Once upon a time,";
            const string middle2 = "The kid climbed a tree";
            const string end2 = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            var story2 = $"{beginning2} {middle2} {end2}";

            // Print the story to the console 
            WriteLine(story2);
        }
    }
}
