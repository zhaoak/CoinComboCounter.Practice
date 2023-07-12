using System;
using System.Collections.Generic;

namespace CoinComboCounter.Models
{
    public class CoinCounter
    {
        // values of the different coins
        private int _quarter = 25;
        private int _dime = 10;
        private int _nickel = 5;
        private int _penny = 1;

        public CoinCounter()
        {

        }

        public Dictionary<String, int> FindCoinCountFromValue(int totalCentValue) {
            // Dictionary to hold counts of each type of coin, init vals to 0
            Dictionary<String, int> totalCoinCount = new Dictionary<String, int>();
            totalCoinCount.Add("Quarters", 0);
            totalCoinCount.Add("Dimes", 0);
            totalCoinCount.Add("Nickels", 0);
            totalCoinCount.Add("Pennies", 0);

            // starting from largest value coin (quarters), count num of coins
            

            return totalCoinCount;
        }
    }
}
