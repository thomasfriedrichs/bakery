using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    
    public void Pastry_InstantiateObject_Pastry0()
    {
      int pastryAmount = 0;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.PastryAmount;
      Assert.AreEqual(pastryAmount, result);
    }
  }
}