using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PierresBakeryTests
  {

    [TestMethod]
    public void PierresBakeryConstructor_CreatesInstancesOf_PierresBakery()
    {
      Game mygame = new Game();
      Assert.AreEqual(typeof(Game), mygame.GetType());
    }

  }