namespace Bread.Models
{
  public class BreadOrder 
  {
    public int BreadAmount {get;set;}

    public BreadOrder(int breadAmount)
    {
      BreadAmount = breadAmount;
    }

    public static int PriceCalc(int breadAmount)
    {
      int price = 0;
      int freeLoaf = breadAmount / 3;
      int leftOver = breadAmount % 3;
      if (breadAmount < 2)
      {
        price = breadAmount * 5;
      } 
      else 
      {
        price = (breadAmount - freeLoaf) * 5;
      }
      return price;
    }
  }
}