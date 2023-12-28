using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using DAL;

namespace Portal.Controllers;

public class InstituteController : Controller
{
    private readonly ILogger<InstituteController> _logger;

    public InstituteController(ILogger<InstituteController> logger)
    {
        _logger = logger;
    }
    public IActionResult Page(){
        return View(); 
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
