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

            // divide total value into quarters, store num of quarters
            totalCoinCount["Quarters"] = totalCentValue / _quarter;
            // store remainder
            int remainder = totalCentValue % _quarter;

            // repeat process with quarters with other coin values
            totalCoinCount["Dimes"] = remainder / _dime;
            remainder = remainder % _dime;

            totalCoinCount["Nickels"] = remainder / _nickel;
            remainder = remainder % _nickel;
            
            // penny count is whatever value is left
            totalCoinCount["Pennies"] = remainder;

            return totalCoinCount;
        }
    }
}
