using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Array List using built in library
            ArrayList myArrList = new ArrayList();

            //Add values to Array List using Add() method
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            //Add values to Array List using AddRange() method
            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            //remove array list elements using RemoveRange() and RemoveAt() and remove() methods
            myArrList.Remove(10); //parameter is element value, in this case remove elements with value of 10
            //now this array list has a total of 5 elements

            myArrList.RemoveAt(0); //parameter is index number, in this case remove element at index 0, which is now 11.5
            //now this array list has 4 elements total

            myArrList.RemoveRange(1, 2); //parameter is index numbers, in this case remove elements from index 1 to before 2


            //print each value in the array list using foreach() method
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
