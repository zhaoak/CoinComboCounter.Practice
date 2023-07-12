using System;
using System.Collections.Generic;
using CoinComboCounter.Models;

namespace CoinComboCounter
{
    class CoinCounterUI
    {
        static void Main()
        {
            Console.WriteLine("**** Coin Calculator ****");
            Console.WriteLine("Given a cent value, this program will return the number of each type of coin it takes to add up to that value!");
            Console.WriteLine("Please enter a cent value now (as an integer).");
            int totalCentValue = int.Parse(Console.ReadLine());

            Dictionary<String, int> coinCount = new Dictionary<String, int>();
            CoinCounter coinCalc = new CoinCounter();
            // shallow copy output
            coinCount = coinCalc.FindCoinCountFromValue(totalCentValue);

            Console.WriteLine($"Coin count for {totalCentValue} cents:");
            Console.WriteLine($"-- Quarters: {coinCount["Quarters"]}");
            Console.WriteLine($"-- Dimes: {coinCount["Dimes"]}");
            Console.WriteLine($"-- Nickels: {coinCount["Nickels"]}");
            Console.WriteLine($"-- Pennies: {coinCount["Pennies"]}");

        }
    }
}
