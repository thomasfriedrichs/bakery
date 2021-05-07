using System;

namespace Bakery
{
  public class Bread 
  {
    public int BreadAmount {get;set;}
    //public int Price {get;set;}

    public Bread(int breadAmount)
    {
      //Price = price;
      BreadAmount = breadAmount;
    }

    public static int PriceCalc(int BreadAmount)
    {
      int Price = 0;
      if (BreadAmount % 3 == 0) 
      {
        Price = (BreadAmount * 5) * (2/3);
      } else 
      {
        Price = BreadAmount * 5;
      }
      return Price;
    }
  }
}