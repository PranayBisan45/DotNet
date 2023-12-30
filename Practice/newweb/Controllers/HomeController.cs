using System.Diagnostics;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using newweb.Models;

using BOL;
namespace newweb.Controllers;

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
  static String msg = null;
  [HttpPost]
  public IActionResult Index(int num, String user, String pass)
  {
    int id = DBManager.Regis(num, user, pass);
    if (id > 0)
    {
      ViewData["msg1"] = "Registration Success!!!";
      // return RedirectToAction("Login");
    }
    return View();


  }



  public IActionResult Login()
  {
    ViewData["msg1"] = msg;
    return View();
  }
  [HttpPost]
  public IActionResult Login(String user, String pass)
  {
    int id = DBManager.Validate(user, pass);
    if (id > 0)
    {
      return RedirectToAction("Privacy");
    }
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
}
