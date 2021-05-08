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
      } else {
        int leftOver = BreadAmount % 3;
        freeLoaf = (BreadAmount - freeLoaf) / 3;
      }


      if (BreadAmount < 2) {
        price = BreadAmount * 5;
      }
      else
      {
        price = (BreadAmount - freeLoaf) * 5;
      } 
      return price;
    }
  }
}