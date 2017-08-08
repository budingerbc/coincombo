using System.Collections.Generic;
using System;


namespace CoinComboApp.Models
{
  public class CoinCombo
  {
     private int _coin;
     private int _quarters;
     private int _dimes;
     private int _nickles;
     private int _pennies;


     public CoinCombo(int input)
     {
      if(input < 0)
      {
        input = 0;
      }

      _coin = input;
      _quarters = 0;
      _dimes = 0;
      _nickles = 0;
      _pennies = 0;
     }

     public int GetQuarters()
     {
       return _quarters;
     }
     public int GetDimes()
     {
       return _dimes;
     }
     public int GetNickles()
     {
       return _nickles;
     }
     public int GetPennies()
     {
       return _pennies;
     }

     public void CalcuateCoins()
     {
      _quarters = _coin / 25;
      _coin = _coin % 25;
      _dimes = _coin / 10;
      _coin = _coin % 10;
      _nickles = _coin / 5;
      _pennies = _coin % 5;

     }




    //  coinvalue / 25 = number of quarters
    //  coinvalue % 25 = change leftover
     //
    //  changeleftover / 10 = number of dimes
    //  changeleftober % 10 = changeleftover

   }
 }
