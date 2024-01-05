using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Exam.Models;
using BOL;
using BLL;

namespace Exam.Controllers;

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
    public IActionResult List()
    {
        List <Employee> list=new List<Employee>();
        list=catalog.getAll();
        ViewData["Employee"]=list;
        return View();
    }
     public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Add(string date,string desc,int duration,string status)
    {
        bool flag= catalog.Add(date,desc,duration,status);
        if(flag)
        {
           return RedirectToAction("List");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
