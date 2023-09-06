using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissorsTests
{
  [TestClass]
  public class RockPaperScissors

  [TestMethod]
  public void Test_Player1Wins_WithRockAndScissors()
  {
    Assert.AreEqual("Player 1", RockPaperScissors.Play("Rock", "Scissors");
  }

  [TestMethod]
  public void Test_Player2Wins_WithPaperandRock()
  {
    Assert.AreEqual("Player 2", RockPaperScissors.Play("Rock , "Paper));
  }

  [TestMethod]
  public void Test_Player2Wins_WithScissorsAndPaper()
  {
    Assert.AreEqual("Player 2", RockPaperScissors.Play("Paper", "Scissors"));
  }

  [TestMethod]
  public void Test_Draw_withSameChoices()


  // Tests will go here!
}
}