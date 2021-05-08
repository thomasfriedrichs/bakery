using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    
    public void Pastry_InstantiateObject_Int()
    {
      int pastryAmount = 0;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.PastryAmount;
      Assert.AreEqual(pastryAmount, result);
    }

    [TestMethod]
    
    public void Pastry_ReturnInt_Int()
    {
      int pastryAmount = 3;
      int price = 5;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int2()
    {
      int pastryAmount = 4;
      int price = 7;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int3()
    {
      int pastryAmount = 2;
      int price = 4;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int4()
    {
      int pastryAmount = 1;
      int price = 2;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int5()
    {
      int pastryAmount = 5;
      int price = 9;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void Pastry_ReturnInt_Int6()
    {
      int pastryAmount = 6;
      int price = 10;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }
  }
}