/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE09 Exercise02
** Date: 2021 - 12 - 5
** Description: Abstract inheritance 
** Learn how to change variables in child classes by overriding them in the base class using 
** Abstract methods and classes
**
********/

using System;
using static System.Console;
namespace InheritanceEX02
{
    class Program
    {
        private static void Main()
        {
            Fashion fashionDepartment = new Fashion();
            fashionDepartment.DisplayPromotions();
            ReadLine();
        }
    }

    // Stores sale event data.
    class Promotion
    {
        public string Name { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Promotion(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
        }
    }

    // Abstract class that stores and displays promotional information.
    abstract class Department
    {
        public abstract string DepartmentName { get; protected set; }
        protected Promotion[] sales;
        protected abstract void AssignPromotions();

        public virtual void DisplayPromotions()
        {
            WriteLine("{0} Department Promotions: ",
                DepartmentName);
            foreach (Promotion sale in sales)
            {
                WriteLine("Name: " + sale.Name);
                WriteLine("Start: " + sale.Start.ToString("m"));
                WriteLine("End: " + sale.End.ToString("m"));
            }
        }
    }

    // Implementing class that sets department name and assigns promotions.
    class Fashion : Department
    {
        public override string DepartmentName { get; protected set; }

        public Fashion()
        {
            DepartmentName = "Fashion";
            AssignPromotions();
        }

        protected override void AssignPromotions()
        {
            DateTime start = new DateTime(2014, 9, 1);  // Sept. 1
            DateTime end = new DateTime(2014, 9, 15); // Sept. 15
            Promotion promotion = new Promotion(start, end, "Fall Sale");
            sales = new Promotion[] { promotion };
        }
    }
}