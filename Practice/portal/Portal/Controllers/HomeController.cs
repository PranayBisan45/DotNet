using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

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

    public IActionResult welcome()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(String UserName,String Password)
    {
        Console.WriteLine(UserName+" "+Password);
        if(UserName=="Pranay" && Password=="Bisan") {
            return RedirectToAction("welcome");
        }
        return View();
    }

    [HttpPost]
     public IActionResult Registration(string fn,string ln, string mn,string fan,string add,string r1, string r2, string r3, string d1, string d2, string dob, string pc, string co, string em )
     {  
       Console.WriteLine(r1+r2+r3);     
       Console.WriteLine(d1+d2);
    
       return this.RedirectToAction("Login");
       
     }
    
    public IActionResult Registration()
    {
    
         return View();
    //    return this.RedirectToAction("welcome");
       
    }
    //  [HttpPost]
    public IActionResult ReadForm(string abc)
    {
        // string ? CourseName=Request.Form["CourseName"];
        // string ? ContactName=Request.Form["ContactName"];
        // string ? Employees=Request.Form["Employees"];
        // Console.WriteLine(CourseName + ContactName + Employees );
        return View();
    }
    // public IActionResult ReadForm()
    // {
    //     return View();
    // }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
