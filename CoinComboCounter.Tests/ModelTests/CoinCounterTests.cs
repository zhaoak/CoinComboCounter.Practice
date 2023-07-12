using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinComboCounter.Models;
using System.Collections.Generic;
using System;

namespace CoinComboCounter.Tests
{
    [TestClass]
    public class CoinCounterTests
    {
        [TestMethod]
        public void CoinCounter_CountsCoins_Dictionary()
        {
            int totalCoinValue = 100;
            CoinCounter testCoinCounter = new CoinCounter();

            Dictionary<String, int> coinQuantities = new Dictionary<String, int>();
            coinQuantities.Add("Quarters", 4);
            coinQuantities.Add("Dimes", 0);
            coinQuantities.Add("Nickels", 0);
            coinQuantities.Add("Pennies", 0);

            Assert.AreEqual(coinQuantities, testCoinCounter.FindCoinCountFromValue(totalCoinValue));
        }
    }
}
