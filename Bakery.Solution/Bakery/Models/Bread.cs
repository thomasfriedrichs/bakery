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

    }
  }
}