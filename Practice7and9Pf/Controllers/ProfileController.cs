using Microsoft.AspNetCore.Mvc;

namespace Practice7Pf.Controllers;

public class ProfileController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Home()
    {
        return View();
    }
    [HttpGet]
    [Route("/projects")]
    public ViewResult Projects()
    {
        return View();
    }
    [HttpGet]
    [Route("/contact")]
    public ViewResult Contact()
    {
        return View();
    }
}