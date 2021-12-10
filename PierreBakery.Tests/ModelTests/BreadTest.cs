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
      Bread newOrder = new Bread(1);

      //Assert
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }

    [TestMethod]
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

    [TestMethod]
    public void GetBreadTotal_ReturnValueOfTotalBreadOrder_Int()
    {
      //Arrange
      int testAmount = 1;
      Bread newOrder = new Bread(testAmount);
      int expectedAmount = 5;

      //Act
      int orderAmount = newOrder.GetBreadTotal();

      //Assert
      Assert.AreEqual(expectedAmount, orderAmount);
    }

    [TestMethod]
    public void GetBreadTotal_ReturnValueOfTotalBreadOrderFor2LoavesOfBread_Int()
    {
      //Arrange
      int testAmount = 2;
      Bread newOrder = new Bread(testAmount);
      int expectedAmount = 10;

      //Act
      int orderAmount = newOrder.GetBreadTotal();

      //Assert
      Assert.AreEqual(expectedAmount, orderAmount);
    }

    [TestMethod]
    public void GetBreadTotal_ReturnValueOfTotalBreadOrderFor3LoavesOfBread_Int()
    {
      //Arrange
      int testAmount = 3;
      Bread newOrder = new Bread(testAmount);
      int expectedAmount = 10;

      //Act
      int orderAmount = newOrder.GetBreadTotal();

      //Assert
      Assert.AreEqual(expectedAmount, orderAmount);
    }
  }
}