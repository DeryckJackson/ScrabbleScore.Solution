using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void GetScore_ReturnsLetterScore_Score()
    {
  // any necessary logic to prep for test; instantiating new classes, etc.
    char letter = 'a';
    int result = Scrabble.GetScore(letter);

    Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void AddScore_AddsValueToScore_Score()
    {
      string word = "snow";
      int result = Scrabble.AddScore(word);

      Assert.AreEqual(result, 7);
    }

  }
}