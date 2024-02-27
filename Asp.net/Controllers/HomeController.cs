using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _net_ilk_odev.Models;

namespace _net_ilk_odev.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Saat()
    {
        return View();
        
        
    }
     public IActionResult Country()
    {
        string[] CountryList = {
            "Rusya",
            "Irak",
            "Suudi Arabistan",
            "Sudan",
            "Yemen",
            "Somali",
           
        };

        ViewBag.Countrys = CountryList;

        return View();
    }

}
