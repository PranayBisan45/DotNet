using System.Diagnostics;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;

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
  public IActionResult Index(int num, String user, String pass,String fav)
  {
    int id = DBManager.Regis(num, user, pass,fav);
    if (id == 1)
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


  public IActionResult Forgot()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Forgot(String reset, String fav)
  {
    int id = DBManager.Forgot(reset, fav);
    if (id == 1)
    {
      return RedirectToAction("Login");
    }
    return View();

  }


   public IActionResult Delete()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Delete(String pass, String fav)
  {
    int id = DBManager.Delete(pass, fav);
    if (id>0)
    {
      return RedirectToAction("Login");
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
