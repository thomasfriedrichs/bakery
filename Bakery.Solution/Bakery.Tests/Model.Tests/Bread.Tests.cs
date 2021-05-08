using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_InstantiateObject_Int()
    {
      int breadAmount = 0;
      Bread newBread = new Bread(breadAmount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount,result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int()
    {
      int BreadAmount = 3;
      int price = 10;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int2()
    {
      int BreadAmount = 4;
      int price = 15;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int3()
    {
      int BreadAmount = 5;
      int price = 20;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int4()
    {
      int BreadAmount = 7;
      int price = 25;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int5()
    {
      int BreadAmount = 20;
      int price = 70;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int6()
    {
      int BreadAmount = 1;
      int price = 5;
      Bread newBread = new Bread(BreadAmount);
      int result = Bread.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }
  }
}
