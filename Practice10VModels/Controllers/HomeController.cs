using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice10VModels.Models;

namespace Practice10VModels.Controllers;

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
        string ViewModelString = "This is a message being passed down";
        return View("Index", ViewModelString);
    }
    [HttpGet("num")]
    public IActionResult Num()
    {
        int[] ViewModelInts = {1,2,3,4,5};
        return View("Num", ViewModelInts);
    }
    [HttpGet("user")]
    public IActionResult AUser()
    {
        User newUser = new User("Bob", "Roberts");
        return View("AUser", newUser);
    }
    [HttpGet("users")]
    public IActionResult AllUsers()
    {
        User Bob = new User("Bob", "Roberts");
        User Tom = new User("Tom", "Roberts");
        User Phil = new User("Phil", "Roberts");
        List<User> UserList = new() {Bob, Tom, Phil};
        return View("AllUsers", UserList);
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
