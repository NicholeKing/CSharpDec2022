using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Making session
        
        HttpContext.Session.SetInt32("MyNum", 1);
        // string name = "Nichole";
        // Console.WriteLine(name);
        // string? Username = HttpContext.Session.GetString("Username");
        return View();
    }

    [HttpPost("Login")]
    public IActionResult Login(string NewName)
    {
        // Strings
        HttpContext.Session.SetString("Username", NewName);
        return RedirectToAction("Privacy");
    }

    public IActionResult Privacy()
    {
        if(HttpContext.Session.GetString("Username") == null)
        {
            return RedirectToAction("Index");
        }
        // string? Username = HttpContext.Session.GetString("Username");
        int? Number = HttpContext.Session.GetInt32("MyNum");
        
        // HttpContext.Session.SetString("Username", "Nichole");
        return View();
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
