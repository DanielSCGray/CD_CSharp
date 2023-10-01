using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice11DSurveyMods.Models;

namespace Practice11DSurveyMods.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
        public static Survey theSurvey;
    [HttpPost("result/process")]
    public IActionResult Process(Survey newSurvey)
    {
        if(!ModelState.IsValid)
        {
            return View("Index");
        }
        theSurvey = newSurvey;
        return RedirectToAction("Result");
    }
    [HttpGet("result")]
    public IActionResult Result()
    {
        return View("Result", theSurvey);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
