using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/MadLibs")]
    public ActionResult MadLibs(string holiday, string nounOne, string place, string person, string adjectiveOne, string bodyPart, string verb, string adjectiveTwo, string nounTwo, string food, string pluralNoun) 
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.Holiday = holiday;
      myMadLibs.NounOne = nounOne;
      myMadLibs.Place = place;
      myMadLibs.Person = person;
      myMadLibs.AdjectiveOne = adjectiveOne;
      myMadLibs.BodyPart = bodyPart;
      myMadLibs.Verb = verb;
      myMadLibs.AdjectiveTwo = adjectiveTwo;
      myMadLibs.NounTwo = nounTwo;
      myMadLibs.Food = food;
      myMadLibs.PluralNoun = pluralNoun;
      return View(myMadLibs); 
    }
  }
}