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

    public void Pastry_ReturnInt_Int2()
    {
      int pastryAmount = 4;
      int price = 7;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = Pastry.PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }
  }
}