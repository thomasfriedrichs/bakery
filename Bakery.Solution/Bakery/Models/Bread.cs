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
      int freeLoaf = 0;
      if (BreadAmount % 3 == 0)
      {
        freeLoaf = BreadAmount / 3;
      }


      if (BreadAmount < 2) {
        price = BreadAmount * 5;
      }
      else if (BreadAmount > 2 && BreadAmount % 3 == 0) 
      {
        price = (int)Math.Round((BreadAmount * 5) * (2/3m)); 
      } 
      return price;
    }
  }
}