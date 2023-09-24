/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE08 EX01
** Date: 2021 - 11 - 28
** Description: Creating a class and using access identifiers to pass variables between classes
** 
********/


using static System.Console;
namespace City
{
    class Program
    {
        static void Main()
        {
            City city = new City("Denver", 2970000);//Object Creation
            WriteLine(city.GetCity());
            WriteLine(city.GetPopulation());
        }
    }

    class City
    {
        private readonly string name;  
        private readonly int population; //Private Data

        //Public Constructor  
        public City(string n, int p)
        {
            name = n;
            population = p;
        }

        public string GetCity() //publicly accessible
        {
            return name;
        }
        public int GetPopulation()
        {
            return population;
        }
    }
}