using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]

  public class PastryTests
  {
    [TestMethod]

    public void PastryConstructor_CreateInstanceOfPastry_Item()
    {
      //Arrange/Act
      Pastry newOrder = new Pastry();

      //Assert
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
  }
}