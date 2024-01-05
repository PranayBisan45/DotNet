using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using DAL;
using Model;
using BLL;
namespace StudentManagement.Controllers;

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
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int roll,string nameFirst,string nameLast)
    {
      
        bool flag = DBManager.addStudent(roll,nameFirst,nameLast);
        if(flag)
        {
            return RedirectToAction("Privacy");
        }
        return View();
    }

    public IActionResult List()
    {
        List<Student> list =new List<Student>();
        list = catalogMaanager.getAll();
        ViewData["Data"]=list;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
