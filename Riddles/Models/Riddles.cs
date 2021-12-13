using System;
using System.Collections.Generic;

namespace Riddles.Models
{
  public class FunRiddle
  {
    public string Input { get; set; }
    public string RiddleQuestion { get; set; }
    public string RiddleAnswer { get; set; }
    public string Output { get; set; }
    public static int QuestionNumber { get; set; }

    public FunRiddle(string question, string answer)
    {
      RiddleQuestion = question;
      RiddleAnswer = answer;
    }

    public bool checkInput()
    {
      if (Input.ToLower() == RiddleAnswer) 
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static void randomQuestion()
    {
      Random randomRiddle = new Random();
      QuestionNumber = randomRiddle.Next(0, 5);
    }
  }
}