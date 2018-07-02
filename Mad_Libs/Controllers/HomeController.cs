using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/mad_libs")]
    public ActionResult MadLib()
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.SetName1(Request.Query["name1"]);
      myMadLibVariable.SetName2(Request.Query["name2"]);
      myMadLibVariable.SetLocation(Request.Query["location"]);
      myMadLibVariable.SetExclamation(Request.Query["exclamation"]);
      myMadLibVariable.SetBodyPart(Request.Query["bodypart"]);
      myMadLibVariable.SetOccupation(Request.Query["occupation"]);
      myMadLibVariable.SetViolentAction(Request.Query["violentaction"]);
      return View("Home", myMadLibVariable);
    }
  }
}
