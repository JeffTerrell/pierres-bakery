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
  }
}