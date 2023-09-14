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
            Bread newBread = new Bread(quantity, price);
            int result = newBread.Price;
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void CalculateTotalCost_CalculatesTotalCostForBread_Int()
        {
            int quantity = 2;
            int price = 5;
            Bread newBread = new Bread(quantity, price);
            int result = newBread.CalculateTotalCost();
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SetQuantity_SetsNewQuantity_Void()
        {
            int quantity = 1;
            int price = 5;
            Bread newBread = new Bread(quantity, price);

            newBread.SetQuantity(3);
            int result = newBread.Quantity;

            Assert.AreEqual(3, result);
        }
    }

    [TestClass]
    public class PartyTest
    {
        [TestMethod]
        public void PartyConstructor_CreatesInstanceOfParty_Party()
        {
            Party newParty = new Party(100, "Birthday");
            Assert.AreEqual(typeof(Party), newParty.GetType());
        }

        [TestMethod]
        public void GetGuestCount_ReturnsGuestCount_Int()
        {
            int guestCount = 100;
            string theme = "Birthday";
            Party newParty = new Party(guestCount, theme);
            int result = newParty.GuestCount;
            Assert.AreEqual(guestCount, result);
        }

        [TestMethod]
        public void SetGuestCount_SetsNewGuestCount_Void()
        {
            int guestCount = 100;
            string theme = "Birthday";
            Party newParty = new Party(guestCount, theme);

            newParty.SetGuestCount(150);
            int result = newParty.GuestCount;

            Assert.AreEqual(150, result);
        }

        [TestMethod]
        public void SetTheme_SetsNewTheme_Void()
        {
            int guestCount = 100;
            string theme = "Birthday";
            Party newParty = new Party(guestCount, theme);

            newParty.SetTheme("Wedding");
            string result = newParty.Theme;

            Assert.AreEqual("Wedding", result);
        }
    }
}
