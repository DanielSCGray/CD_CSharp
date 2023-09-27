

using Microsoft.AspNetCore.Mvc;

namespace Practice8Razor.Controllers;

public class IndexController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }
    
}