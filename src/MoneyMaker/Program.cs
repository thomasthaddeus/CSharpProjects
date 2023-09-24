/************************
** 
** Written by: Thaddeus Thomas
** Date: 9/11/2022
** 
** Converts money from one size to another
** Gold, silver, & bronze are used for this program 
** 
*************************/

using static System.Console;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main()
        {
            WriteLine("Welcome to Money Maker!");
            Write("Enter an amount to convert to coins: ");
            string totalAsString = Console.ReadLine();
            double totAsDouble = Convert.ToDouble(totalAsString);
            int goldValue = 10;
            int silverValue = 5;

            //find the amount of coins that fit into gold
            double goldCoins = Math.Floor(totAsDouble / goldValue);
            double remainder = totAsDouble % goldValue;
            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            //Print all Coins
            WriteLine($"{totalAsString} cents is equal to...");
            WriteLine($"Gold coins: {goldCoins}");
            WriteLine($"Silver coins: {silverCoins}");
            WriteLine($"Bronze coins: {remainder}");
        }
    }
}
