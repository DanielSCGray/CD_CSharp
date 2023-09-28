using Microsoft.AspNetCore.Mvc;

namespace Core5DojoSurvey1.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Survey()
    {
        return View();
    }
    // [HttpPost("process")]
    // public RedirectToActionResult Process(string Name, string Location, string Language, string Comment)
    // {
    //     RedirectToAction("Results", new{name=Name},new{location=Location},new{language=Language},new{comment=Comment});
    // }
    [HttpPost("result")]
    public ViewResult Results(string Name, string Location, string Language, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;

        return View();
    }
}
// (string name, string location, string language, string comment)