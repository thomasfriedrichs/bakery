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
      int pastryAmount = 5;
      int price = 9;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = PriceCalc(pastryAmount);
      Assert.AreEqual(price, result);
    }
  }
}