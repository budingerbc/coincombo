using CoinComboApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace CoinComboApp.Test
{
  [TestClass]
  public class CoinComboTest
  {

    [TestMethod]
    public void CoinSplitInput_True()
    {
      CoinCombo test = new CoinCombo(3);
      test.CalcuateCoins();

      Assert.AreEqual(3, test.GetPennies());
    }
    [TestMethod]
    public void CalculateCoins_Testing123Cents_True()
    {
      CoinCombo test = new CoinCombo(124);
      test.CalcuateCoins();

      Assert.AreEqual(4, test.GetQuarters());
      Assert.AreEqual(2, test.GetDimes());
      Assert.AreEqual(0, test.GetNickles());
      Assert.AreEqual(4, test.GetPennies());
    }

    [TestMethod]
    public void CalcuateCoins_TestNegativeCents_True()
    {
      CoinCombo test = new CoinCombo(-5);
      test.CalcuateCoins();

      Assert.AreEqual(0, test.GetQuarters());
      Assert.AreEqual(0, test.GetDimes());
      Assert.AreEqual(0, test.GetNickles());
      Assert.AreEqual(0, test.GetPennies());
    }




  }



}
