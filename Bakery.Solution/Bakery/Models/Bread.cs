using System;

namespace Bakery
{
  public class Bread 
  {
    public int BreadAmount {get;set;}

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
    }

    public static int PriceCalc(int BreadAmount)
    {
      int price = 0;
      if (BreadAmount % 3 == 0) 
      {
        price = (int)Math.Round((BreadAmount * 5) * (2/3m));
      } else 
      {
        price = BreadAmount * 5;
      }
      return price;
    }
  }
}