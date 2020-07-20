using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public static class Scrabble
  {
    private static Dictionary<char, int> _letterScore = new Dictionary<char, int>
    {
      { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1}, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 },
    };

  public static int GetScore(char letter)
  {
    if (_letterScore.ContainsKey(letter))
    {
      return _letterScore[letter];
    }
    else
    {
      return 0;
    }
  }

  public static int AddScore(string word)
  {
    int score = 0;
    foreach (char letter in word)
    {
      score += GetScore(letter);
    }
    return score;
  }
  
  }
}