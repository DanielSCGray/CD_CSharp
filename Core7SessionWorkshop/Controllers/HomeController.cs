using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Core7SessionWorkshop.Models;
using System.Globalization;
using System;

namespace Core7SessionWorkshop.Controllers;

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
    [HttpPost("setname")]
    public IActionResult SetName(User newUser)
    {
        if(!ModelState.IsValid)
        {
            return View("Index");
        }
        HttpContext.Session.SetString("UserName", newUser.Name);
        HttpContext.Session.SetInt32("MyNumber", 22);
        return RedirectToAction("Dashboard");
    }
    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        ViewBag.Name = HttpContext.Session.GetString("UserName");
        ViewBag.MyNumber = HttpContext.Session.GetInt32("MyNumber");
        return View();
    }
    [HttpPost("domath")]
    public IActionResult DoMath(string DoThis)
    {
        Random rand = new();
        int? num = HttpContext.Session.GetInt32("MyNumber");
        if (DoThis == "+1")
        {
            num +=1;
            int NewNum = (int)num;
            HttpContext.Session.SetInt32("MyNumber", NewNum);
        }
        else if (DoThis == "-1" )
        {
        num -=1;
        int NewNum = (int)num;
            HttpContext.Session.SetInt32("MyNumber", NewNum);
        }
        else if (DoThis == "x2" )
        {
        num *=2;
        int NewNum = (int)num;
            HttpContext.Session.SetInt32("MyNumber", NewNum);
        }
        else if (DoThis == "+Random" )
        {
        num +=rand.Next(1,11);
        int NewNum = (int)num;
            HttpContext.Session.SetInt32("MyNumber", NewNum);
        }
        return RedirectToAction("Dashboard");
    }
    [HttpPost("logout")]
    public IActionResult LogOut()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
