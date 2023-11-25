using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Asp.NET";
        kurs.Description = "Asp.NET using backend developing in web technology.";
        return View(kurs);
    }
    public IActionResult List()
    {
        var kurslar = new List<Course>()
       {
           new Course() { Id = 1, Title = "Asp.Net", Description = "Asp.NET using backend developing in web technology.",Image="1.jpg"},
           new Course() { Id = 2, Title = "JavaScript", Description = "JavaScript ile frontend geliştirmeye giriş.",Image="2.jpg"},
new Course() { Id = 3, Title = "C# Programming", Description = "C# programlama dilinin temelleri." ,Image="3.jpg"}
       };
        return View("List",kurslar);
    }
}