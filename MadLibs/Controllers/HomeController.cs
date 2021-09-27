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
    public ActionResult MadLibs(string holiday, string nounOne, string place) 
    {
      MadLibsVariable myMadLibs = new MadLibsVariable();
      myMadLibs.Holiday = holiday;
      myMadLibs.NounOne = nounOne;
      myMadLibs.Place = place;
      return View(myMadLibs); 
    }
  }
}