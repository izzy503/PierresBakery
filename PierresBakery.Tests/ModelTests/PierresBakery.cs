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
            Bread newBread = new Bread(1, 5);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void GetPrice_ReturnsPrice_Int()
        {
            int quantity = 1;
            int price = 5;
            Bread newBread = new Bread(quantity);
            int result = newBread.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void CalculateTotalCost_CalculatesTotalCostForBread_Int()
        {
            int quantity = 2;
            int price = 5;
            Bread newBread = new Bread(quantity);
            int result = newBread.CalculateTotalCost();
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SetQuantity_SetsNewQuantity_Void()
        {
            int quantity = 1;
            int price = 5;
            Bread newBread = new Bread(quantity);

            newBread.SetQuantity(3);
            int result = newBread.Quantity;

            Assert.AreEqual(3, result);
        }
    }


}

