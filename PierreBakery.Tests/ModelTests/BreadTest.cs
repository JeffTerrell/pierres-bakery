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
      //Arrange/Act
      Bread newOrder = new Bread();

      //Assert
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    public void GetBreadOrder_ReturnValueOfBreadOrder_Int()
    {
      //Arrange
      int testAmount = 1;
      Bread newOrder = new Bread(testAmount);

      //Act
      int orderAmount = newOrder.BreadOrder;

      //Assert
      Assert.AreEqual(testAmount, orderAmount);
    }
  }
}