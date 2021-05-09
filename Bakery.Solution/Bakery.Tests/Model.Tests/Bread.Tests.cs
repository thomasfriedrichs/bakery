using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bread.Models.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_InstantiateObject_Int()
    {
      int breadAmount = 0;
      BreadOrder newBread = new BreadOrder(breadAmount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount,result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int()
    {
      int BreadAmount = 3;
      int price = 10;
      BreadOrder newBread = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int2()
    {
      int BreadAmount = 4;
      int price = 15;
      BreadOrder newBread = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int3()
    {
      int BreadAmount = 5;
      int price = 20;
      BreadOrder newBreadOrder = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int4()
    {
      int BreadAmount = 7;
      int price = 25;
      BreadOrder newOrder = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int5()
    {
      int BreadAmount = 20;
      int price = 70;
      BreadOrder newBread = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void PriceCalc_ReturnPrice_Int6()
    {
      int BreadAmount = 1;
      int price = 5;
      BreadOrder newBread = new BreadOrder(BreadAmount);
      int result = BreadOrder.PriceCalc(BreadAmount);
      Assert.AreEqual(price, result);
    }
  }
}
