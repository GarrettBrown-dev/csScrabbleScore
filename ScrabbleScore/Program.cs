using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine("Enter a word to check its scrabble score or x to exit: ");
      string userInput = Console.ReadLine();
        if (userInput != "x")
        {
          Console.WriteLine("The score is " + Score.GetScore(userInput));
          i--;
        }
        else
        {
          break;
        }
      }
    }
  }
}
