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
      Pastry newOrder = new Pastry(1);

      //Assert
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnValueOfPastryOrder_Int()
    {
      //Arrange
      int testAmount = 1;
      Pastry newOrder = new Pastry(testAmount);

      //Act
      int orderAmount = newOrder.PastryOrder;

      //Assert
      Assert.AreEqual(testAmount, orderAmount);
    }

    [TestMethod]
    public void GetPastryTotal_ReturnValueOfTotalBreadOrder_Int()
    {
      //Arrange
      int testAmount = 1;
      Pastry newOrder = new Pastry(testAmount);

      //Act
      int orderAmount = newOrder.GetPastryTotal();

      //Assert
      Assert.AreEqual(testAmount, orderAmount);
    }
  }
}