using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using Riddles.Models;
using System;
using System.Collections.Generic;

namespace Riddles.Controllers
{
  public class HomeController : Controller
  {
    
    static FunRiddle RiddleOne = new FunRiddle("The more you code, the more of me there is. I may be gone for now but you can’t get rid of me forever. What am I?", "a bug");
    static FunRiddle RiddleTwo = new FunRiddle("As a developer I’m your eyes, showing you the result of your code in your language of choice. What am I?", "a print statement");
    static FunRiddle RiddleThree = new FunRiddle("As a developer, you usually get mad at me because I complain a lot, although I’m usually right. What am I?", "a compiler");
    static FunRiddle RiddleFour = new FunRiddle("I’m a language for everything yet I have no real identity of my own. Good luck trying to compile me. What am I?", "pseudocode");
    static FunRiddle RiddleFive = new FunRiddle("I’m a simple thing, nothing special. While I have many cousins we’re all very similar because we set your project up. What am I?", "a configuration file");

    static List<FunRiddle> RiddlesList = new List<FunRiddle>(){RiddleOne, RiddleTwo, RiddleThree, RiddleFour, RiddleFive};

    [Route("/")]
    public ActionResult Form() 
    { 
      FunRiddle.randomQuestion();
      return View(RiddlesList[FunRiddle.QuestionNumber]);
    }

    [Route("/showriddles")]
    public ActionResult ShowRiddles(string input) 
    {
      RiddlesList[FunRiddle.QuestionNumber].Input = input;
      if (RiddlesList[FunRiddle.QuestionNumber].checkInput())
      {
        RiddlesList[FunRiddle.QuestionNumber].Output = "Correct!";
      }
      else
      {
        RiddlesList[FunRiddle.QuestionNumber].Output = "Sorry that was incorrect";
      }
      return View(RiddlesList[FunRiddle.QuestionNumber]);
    }

  }
    
}