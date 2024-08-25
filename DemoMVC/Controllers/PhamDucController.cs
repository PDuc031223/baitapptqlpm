using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class PhamDucController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
