using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests.ModelTests
{
  [TestClass]
  public class PierresPastriesTests
  {
    [TestMethod]
    public void Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsSinglePastryPrice_Int()
    {
      int quantity = 1;
      int price = 2;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.SinglePastryPrice;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void CalculateTotalCost_CalculatesTotalCostForPastry_Int()
    {
      int quantity = 2;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.CalculateTotalCost();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void SetQuantity_SetsNewQuantity_Void()
    {
      //Arrange
      int quantity = 2;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      //Act
      newPastry.SetQuantity(4);
      //Assert
      Assert.AreEqual(4, newPastry.Quantity);

    }

    [TestMethod]
    public void GetFreePastries_DetermineAmountofFreePastry_int()
    {
      int quantity = 4;
      int freePastry = 1;
      Pastry newPastry = new Pastry(quantity);

      int testFreePastry = newPastry.GetFreePastries();
      Assert.AreEqual(freePastry, testFreePastry);
    }

    [TestMethod]
    public void IsEligibleForDiscount_DeterminesIfOrderIsDiscount_bool()
    {
      int quantity = 5;
      Pastry testPastry = new Pastry(quantity);
      bool IsEligibleForDiscount = testPastry.IsEligibleForDiscount();//Act
      Assert.IsTrue(IsEligibleForDiscount); //Assert
    }

    [TestMethod]
    public void UpdatePricePerPastry_UpdatesPastryPrice_int()
    {
      //Arrange
      int initialPrice = 2;
      int quantity = 4;
      Pastry newPastry = new Pastry(quantity);
      //Act
      newPastry.UpdatePricePerPastry(initialPrice);
      //Assert
      Assert.AreEqual(initialPrice, newPastry.SinglePastryPrice);
    }
  }
}