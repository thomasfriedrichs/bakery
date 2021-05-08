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
      int freeLoaf = BreadAmount / 3;
      int leftOver = BreadAmount % 3;
      if (BreadAmount < 2)
      {
        price = BreadAmount * 5;
      } 
      else if (BreadAmount % 3 == 0)
      {
        price = (int)Math.Round(BreadAmount * (2/3m) * 5);
      }
      else 
      {
        price = ((BreadAmount - freeLoaf) * 5);
      }
      
      
      
      // if (BreadAmount % 3 == 0)
      // {
      //   freeLoaf = BreadAmount / 3;
      // } else {
      //   int leftOver = BreadAmount % 3;
      //   freeLoaf = (BreadAmount - freeLoaf) / 3;
      // }

      // if (BreadAmount < 2) {
      //   price = BreadAmount * 5;
      // }
      // else
      // {
      //   price = (BreadAmount - freeLoaf) * 5;
      // } 
      return price;
    }
  }
}