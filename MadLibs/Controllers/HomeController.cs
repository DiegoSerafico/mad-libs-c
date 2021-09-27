using HalloweenMadLib.Models;
using ChristmasMadLib.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Select() { return View(); }

    [Route("/halloween-form")]
    public ActionResult HalloweenForm() { return View(); }

    [Route("/christmas-form")]
    public ActionResult ChristmasForm() { return View(); }

    [Route("/halloween-mad-lib")]
    public ActionResult HalloweenMadLib(string holiday, string nounOne, string place, string person, string adjectiveOne, string bodyPart, string verb, string adjectiveTwo, string nounTwo, string food, string pluralNoun) 
    {
      HalloweenMadLibVariable myMadLibs = new HalloweenMadLibVariable();
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

    [Route("/christmas-mad-lib")]
    public ActionResult ChristmasMadLib(string nounOne, string nounTwo, string verbOne, string nounThree, string adjectiveOne, string nounFour, string verbTwo, string nounFive, string nounSix) 
    {
      ChristmasMadLibVariable myMadLibs = new ChristmasMadLibVariable();
      myMadLibs.NounOne = nounOne;
      myMadLibs.NounTwo = nounTwo;
      myMadLibs.VerbOne = verbOne;
      myMadLibs.NounThree = nounThree;
      myMadLibs.AdjectiveOne = adjectiveOne;
      myMadLibs.NounFour = nounFour;
      myMadLibs.VerbTwo = verbTwo;
      myMadLibs.NounFive = nounFive;
      myMadLibs.NounSix = nounSix;
      return View(myMadLibs); 
    }
  }
}