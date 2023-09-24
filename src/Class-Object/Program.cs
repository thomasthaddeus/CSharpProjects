/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: HOP08
** Date: 2021 - 11 - 28
** Description: outputs the area of Area of a Circle, Square and Rectangle 
** using methods from different classes
**
********/

using System;
using static System.Console;

namespace Class_Object
{
    class Shapes //Create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }

        public double CalCircleArea(double r) 
        {
            radius = r;
            double Area = 3.14 * r * r;
            return Area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double Radius = 3;

            Shapes Rectangle = new Shapes();
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes();

            //use Object Rectangle to call method CalArea of class Shapes 
            WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            //use Object Square to call method CalArea of class Shapes
            WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            //use object Circle to call method CalCircleArea of class Shapes
            WriteLine("Area of Circle is: " + Circle.CalCircleArea(Radius));
        }
    }
}