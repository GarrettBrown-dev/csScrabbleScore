using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void GetScore_GetScoreFromUserWord_Score()
    {
      Assert.AreEqual("8", Score.GetScore("word"));
    }
  }
}