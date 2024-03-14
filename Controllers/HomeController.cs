using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uygulama.Models;

namespace Uygulama.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
	[HttpGet]
	public IActionResult DavetiyeCevabi()
    {
        return View();
    }
	[HttpPost]
	public IActionResult DavetiyeCevabi(DavetiyeCevabi formdangelencevap)
    {
        return View("Thanks", formdangelencevap);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
