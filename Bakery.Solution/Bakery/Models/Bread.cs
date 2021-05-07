using System;

namespace Bakery
{
  public class Bread 
  {
    public int BreadAmount {get;set;}
    public int Price {get;set;}

    public Bread(int breadAmount, int price)
    {
      Price = price;
      BreadAmount = breadAmount;
    }

    public static int PriceCalc(int BreadAmount)
    {
      if (BreadAmount % 3 == 0) 
      {
        return (BreadAmount * 5) * (2/3);
      } else 
      {
        return BreadAmount * 5;
      }
    }
  }
}