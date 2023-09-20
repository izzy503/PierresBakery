using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests.ModelTests
{
    [TestClass]
    public class BreadTest
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetPrice_ReturnsSingleLoafPrice_Int()
        {
            int quantity = 1;
            int price = 5;
            Bread newBread = new Bread(quantity);
            int result = newBread.SingleLoafPrice; 
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void CalculateTotalCost_CalculatesTotalCostForBread_Int()
        {
            int quantity = 2;
            Bread newBread = new Bread(quantity);
            int result = newBread.CalculateTotalCost();
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SetQuantity_SetsNewQuantity_Void()
        {
            int quantity = 1;
            Bread newBread = new Bread(quantity);

            newBread.SetQuantity(3);
            int result = newBread.Quantity;

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetFreeLoaves_DetermineAmountofFreeLoaves_int()
        {
            int quantity = 3;
            int freeloaves = 1;
            Bread newBread = new Bread(quantity);

            int testFreeLoaves = newBread.GetFreeLoaves();
            Assert.AreEqual(freeloaves, testFreeLoaves);

        } 

        // IsEligibleForDiscount()
        [TestMethod]
        public void IsEligibleForDiscount_DeterminesIfOrderIsDiscount_bool()
        {
            int quantity = 5; 
            Bread bread = new Bread(quantity);
            bool IsEligibleForDiscount = bread.IsEligibleForDiscount();//Act
            Assert.IsTrue(IsEligibleForDiscount); //Assert
        }

        // UpdatePricePerLoaf(int newPrice)
        [TestMethod]
        public void UpdatePricePerLoaf_UpdatesLoafProce_int()
        {
            //Arrange
            int initialPrice = 2;
            // int newPrice = 3;
            int quantity = 4;
            Bread newBread = new Bread(quantity);
            //Act
            newBread.UpdatePricePerLoaf(initialPrice);
            // int updatedPrice = newBread.UpdatePricePerLoaf(3);
            //Assert
            Assert.AreEqual(initialPrice, newBread.SingleLoafPrice);
            
        }

    }
}

        

