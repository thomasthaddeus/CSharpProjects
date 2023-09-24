/*********
**
** Name: Thomas, Thaddeus
** Class: CS 132
** Project: PE08 EX03
** Date: 2021 - 11 - 28
** Description: Creating a class and using access identifiers to pass variables between classes
** Modifys The City Class Definition to show an info message
**
********/


using static System.Console;
namespace City
{
    class Program
    {
        static void Main()
        {
            WriteLine(City.Version);
            City city = new City("Denver", 2970000, "USA");//Object Creation
            WriteLine(city.GetCity());
            WriteLine(city.GetPopulation());
            WriteLine(city.Country); //readonly
        }
    }

    class City
    {
        private readonly string name;  
        private readonly int population; //Private Data
        private readonly string country;

        //Public Constructor  
        public City(string n, int p, string cy)
        {
            name = n;
            population = p;
            country = cy;
        }

        public string GetCity() //publicly accessible
        {
            return name;
        }
        public int GetPopulation()
        {
            return population;
        }
        public string Country { get { return country; }private set { } }
        public static string Version = "City Info Version 1.0";
    }
}