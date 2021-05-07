using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // [TestMethod]
    // public void Bread_InstantiateObject_price0()
    // {
    //   int price = 0;
    //   int breadAmount = 0;
    //   Bread newBread = new Bread(breadAmount,price);
    //   int result = newBread.Price;
    //   Assert.AreEqual(result, 0);
    // }

    [TestMethod]
    public void Bread_InstantiateObject_bread0()
    {
      //int price = 0;
      int breadAmount = 0;
      Bread newBread = new Bread(breadAmount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int()
    {
      //int price = 0;
      int breadAmount = 3;
      int price = 10;
      Bread newBread = new Bread(breadAmount);
      int result = Bread.PriceCalc(breadAmount);
      Assert.AreEqual(price, result);
    }
  }
}
