using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentManagementMVC.Models;
using BOL;
using BLL;
namespace StudentManagementMVC.Controllers;

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
    public IActionResult List(){
        List<Student> st=new List<Student>();
        st=Catalog.getAll();
        ViewData["student"]=st;
        return View();
    }
    public IActionResult Edit(int id){
         List<Student> st=new List<Student>();
        st=Catalog.getAll();
        Student s=st.Find((s)=>s.id==id);
        ViewData["singleData"]=s;
        return View();

    }
    [HttpPost]
    public IActionResult Edit(int id, String nameFirst, String namelast, String email){
            bool flag=Catalog.Update(id,nameFirst,namelast,email);
            
            if(flag){
            return RedirectToAction("List");
            }
            return View();

    }
     public IActionResult Delete(int id){
         List<Student> st=new List<Student>();
        st=Catalog.getAll();
        Student s=st.Find((s)=>s.id==id);
        ViewData["singleData"]=s;
        return View();

    }
    [HttpPost]
    public IActionResult Delete(int id, String nameFirst, String namelast, String email){
            bool flag=Catalog.Delete(id);
            
            if(flag){
            return RedirectToAction("List");
            }
            return View();

    }

    public IActionResult Add(){
        return View();
    }
    [HttpPost]
    public IActionResult Add(int id, String nameFirst, String namelast, String email){
        bool flag=Catalog.AddData(id,nameFirst,namelast,email);
        if(flag){
            return RedirectToAction("List");
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
