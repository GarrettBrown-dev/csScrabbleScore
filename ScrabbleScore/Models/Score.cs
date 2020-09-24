using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public static string GetScore(string userInput)
    {
    Dictionary <int, string> letters = new Dictionary<int, string>(){
    { 1, "a" }, { 3, "b" }, { 3, "c" }, { 2, "d" }, { 1, "e" }, { 4, "f" },
    { 2, "g" }, { 4, "h" },{ 1, "i" }, { 8, "j" }, { 5, "k" }, { 1, "l" },
    { 3, "m" }, { 1, "n" }, { 1, "o" }, { 3, "p" },{ 10, "q" }, { 1, "r" },
    { 1, "s" }, { 1, "t" }, { 1, "u" }, { 4, "v" },{ 4, "w" }, { 8, "x" },
    { 4, "y" }, { 10, "z" }
    };  

    int totalScore = 0;
    string user = userInput.ToLower();

    for (int i = 0; i < user.Length; i++)
    {
      foreach(KeyValuePair<int, string> letter in letters)
      {
        if (letter.Value == user[i].ToString())
        {
          totalScore += letter.Key;
        }
      }
    }
      return "null"; //totalScore.ToString();
    }
  }
}