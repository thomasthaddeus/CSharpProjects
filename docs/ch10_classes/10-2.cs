using System;

namespace Starter {
    class Program {
        public static void Main() {
            // Declare question with an integer and string response.
            QuizQuestion<int, string> question = new QuizQuestion<int, string>
                ("Approximately how many shark species exist?", 350, "None of the above.");
            question.ShowTypes();
            question.ShowQuestion();
            Console.ReadLine();
        }
    }

    // Declare class that implements two generic types.
    class QuizQuestion<T, U> {
        private string Question { set; get; }
        private T ResponseA;
        private U ResponseB;
        
        // Constructor.
        public QuizQuestion(string question, T a, U b) {
            Question  = question;
            ResponseA = a;
            ResponseB = b;
        }

        // Show data types.
        public void ShowTypes() {
            Console.WriteLine("(a) is a " + typeof (T).ToString());
            Console.WriteLine("(b) is a " + typeof (U).ToString());
        }

        public void ShowQuestion() {
            Console.WriteLine(Question);
            Console.WriteLine("a) " + ResponseA.ToString());
            Console.WriteLine("b) " + ResponseB.ToString());
        }
    }
}
