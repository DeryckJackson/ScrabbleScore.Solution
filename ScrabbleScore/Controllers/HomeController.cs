using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]

    public ActionResult Directory() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs(string person1, string person2, string animal, string exclamation, string adverb, string verb, string adjective, string noun )
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Person1 = person1;
      myMadLibsVariable.Person2 = person2;
      myMadLibsVariable.Animal = animal;
      myMadLibsVariable.Exclamation = exclamation;
      myMadLibsVariable.Adverb = adverb;
      myMadLibsVariable.Verb = verb;
      myMadLibsVariable.Adjective = adjective;
      myMadLibsVariable.Noun = noun;

      return View(myMadLibsVariable);
    }


  }
}