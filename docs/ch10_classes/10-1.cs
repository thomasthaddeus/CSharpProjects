using System;

namespace Starter {
    class Program {
        public static void Main() {
            // Initialize question with an 'integer' type.
            QuizQuestion<int> questionA = new QuizQuestion<int>
                ("How many teeth do sharks use in a lifetime?", 30000);
            questionA.ShowType();
            questionA.ShowQandA();

            // Initialize question with a 'string' type.
            QuizQuestion<string> questionB = new QuizQuestion<string>
                ("What type of shark swims fastest?", "The short fin mako shark.");
            questionB.ShowType();
            questionB.ShowQandA();
            Console.ReadLine();
        }
    }

   // Declare class with dynamically typed data members.
    class QuizQuestion<T> {
        public T Answer { get; private set; } // Generic property.
        private string Question { get; set; } // String property.

        public QuizQuestion(string question, T answer) {
            // Constructor.
            Question = question;
            Answer   = answer;
        }

        public void ShowType() {
            // Show data type.
            Console.Write("The instance type is: ");
            Console.WriteLine(typeof (T).ToString());
        }

        public void ShowQandA() {
            // Question & Answer
            Console.WriteLine("Question: " + Question);
            Console.WriteLine("Answer: " + Answer.ToString() + "\n");
        }
    }
}