using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pastry.Models.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    
    public void Pastry_InstantiateObject_Int()
    {
      int pastryAmount = 0;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = newPastry.PastryAmount;
      Assert.AreEqual(pastryAmount, result);
    }

    [TestMethod]
    
    public void Pastry_ReturnInt_Int()
    {
      int pastryAmount = 3;
      int price = 5;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int2()
    {
      int pastryAmount = 4;
      int price = 7;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int3()
    {
      int pastryAmount = 2;
      int price = 4;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int4()
    {
      int pastryAmount = 1;
      int price = 2;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int5()
    {
      int pastryAmount = 5;
      int price = 9;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int6()
    {
      int pastryAmount = 6;
      int price = 10;
      PastryOrder newPastry = new PastryOrder(pastryAmount);
      int result = PastryOrder.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }
  }
}