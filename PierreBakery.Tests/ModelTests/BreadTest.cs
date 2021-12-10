using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]

  public class BreadTests
  {
    [TestMethod]

    public void BreadConstructor_CreatesInstanceOfBread_Item()
    {
      Bread newOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    public void GetBreadOrder_ReturnValueOfBreadOrder_Int()
    {
      int testAmount = 1;
      Bread newOrder = new Bread(testAmount);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

  }
}