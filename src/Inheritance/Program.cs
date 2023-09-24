/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP09
** Date: 2021 - 12 - 5
** Description: Inheritance from class to class
** Have the class shapes showing the properties as a function
**
********/

using System;
using static System.Console;

namespace Inheritance
{
    class Program
    {
        class Shapes //Create class named Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;

            public String toString()
            {
                return "\n Length: " + length + "\n Width: " + width + "\n Radius: " + radius;
            }
        }
          
        class Rectangle : Shapes //Rectangle class derived from Shapes base 
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                WriteLine("Rectangle length is: " + length);
                WriteLine("Rectangle width is: " + width);
                WriteLine("Rectangle Area is: " + RecArea);
            }
        }

        class Square : Shapes //Square class derived from Shapes base class
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                WriteLine("Square side lenght is: " + a);
                WriteLine("Square Area is: " + SqArea);
            }
        }

        class Circle : Shapes //Circle class derived from Shapes base class
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                WriteLine("Circle radius is: " + radius);
                WriteLine("Circle Area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle(); //object MyRec of class Rectangle
            
            Circle MyCir = new Circle(); //object MyCir of class Circle

            Square MySq = new Square(); //object MySq of class Square

            //using objects to call properties of it classes. Since all Rectangle, Square and Circle classes
            //are derived from base class Shapes, all of those classes have access to Shapes' properties
            //making their objects also able to access
            //length, width and radius, which are the propertiesof base class Shapes
            WriteLine("\n"); //jump to next line

            MyRec.CalArea(3, 4);
            WriteLine("\n"); //jump to next line

            MySq.CalArea(10);
            WriteLine("\n"); //jump to next line

            MyCir.CalArea(8);

            //calling base class properties using child class objects
            WriteLine("Rectangle properties" + MyRec.toString());
            WriteLine("Square properties" + MySq.toString());
            WriteLine("Circle properties" + MyCir.toString());
        }
    }
}
