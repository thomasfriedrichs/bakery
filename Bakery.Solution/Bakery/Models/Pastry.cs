using System;

namespace Bakery
{
  public class Pastry
  {
    public int PastryAmount {get;set;}

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }

    public static int PriceCalc(int pastryAmount)
    {
      int price = 0;
      int leftOver = pastryAmount % 3;
      if (pastryAmount < 3)
      {
        price = pastryAmount * 2;
      } 
      else 
      {
        price = (int)Math.Round((pastryAmount - leftOver) * (5/3m)) + (leftOver * 2);
      }
      return price;
    }
  }
}