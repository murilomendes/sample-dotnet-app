using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using my_log_app_test.Models;

namespace my_log_app_test.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Teste Log Warning - Index - Home Controller ");
        _logger.LogWarning("Teste Log Warning - Index - Home Controller ");
        _logger.LogError("Teste Log Error - Index - Home Controller ");

        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogInformation("Teste Log Warning - Index - Home Controller ");
        _logger.LogWarning("Teste Log Warning - Privacy - Home Controller ");
        _logger.LogError("Teste Log Error - Privacy - Home Controller ");

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

