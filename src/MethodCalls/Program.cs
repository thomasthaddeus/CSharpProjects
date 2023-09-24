/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE04 Ex_1 MEthod Calls
** Date: 2021 - 10 - 30
** Description: Creating and implementing methods 
** passing methods by reference and having equally weighted values
**
********/

using System;
namespace MethodCalls{
    class Program{
        private const string V = "G. Treele";

        static void Main(){
            const float MATH_GRADE = 80f;
            const float BIOLOGY_GRADE = 80.0f;
            const float PROGRAMMING_GRADE = 92.0f;
            const string STUDENT_NAME = V;
            // Call CalculateAverage() to calculate the average grade.
            float average = CalculateAverage(MATH_GRADE, BIOLOGY_GRADE, PROGRAMMING_GRADE);

            // Call ShowAverage() to display the student name and overall average.
            ShowAverage(STUDENT_NAME, average); //I shouldve changed "average" because wow it tripped me up
            Console.ReadLine();
        }

        static float CalculateAverage(float MATH_GRADE, float BIOLOGY_GRADE, float PROGRAMMING_GRADE){
            float sum = MATH_GRADE + BIOLOGY_GRADE + PROGRAMMING_GRADE;
            if (sum > 0)
                return (sum / 3);
            else
                return -1;
        }

        static void ShowAverage(string STUDENT_NAME, float average) //static and void because it never referenced in the main method and the values wont change
        {
            Console.WriteLine(STUDENT_NAME + " average: " + average);
        }
    }
}

