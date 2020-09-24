using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public static string GetScore(string userInput)
    {
    Dictionary <string, int> letters = new Dictionary<string, int>(){
    { "a", 1 }, { "b", 3 }, { "c", 3 }, { "d", 2 }, { "e", 1 }, { "f", 4 },
    { "g", 2 }, { "h", 4 }, { "i", 1 }, { "j", 8 }, { "k", 5 }, { "l", 1 },
    { "m", 3 }, { "n", 1 }, { "o", 1 }, { "p", 3 }, { "q", 10 }, { "r" , 1 },
    { "s", 1 }, { "t", 1 }, { "u", 1 }, { "v", 4 }, { "w", 4 }, { "x", 8 },
    { "y", 4 }, { "z", 10 }
    };  

    int totalScore = 0;
    string user = userInput.ToLower();

    for (int i = 0; i < user.Length; i++)
    {
      foreach(KeyValuePair<string, int> letter in letters)
      {
        if (letter.Key == user[i].ToString())
        {
          totalScore += letter.Value;
        }
      }
    }
      return totalScore.ToString();
    }
  }
}