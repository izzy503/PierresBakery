using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

namespace BakeryApp.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void Bread_CreatesNewInstanceOfBread_Bread()
        {
            // Test cases for the Bread class will be implemented here.
            Bread myBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), myBread.GetType());
        }

    
    }
}
