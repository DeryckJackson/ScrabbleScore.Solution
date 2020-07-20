using System;
using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/scrabble")]
    public ActionResult Scrabble(string word)
    {
      Scrabble myScrabble = new Scrabble();
      myScrabble.AddScore(word);

      return View(myScrabble);
    }


  }
}