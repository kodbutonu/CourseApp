using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController:Controller{

public IActionResult Index(){
    var kurs=new Course();
    kurs.Id=1;
    kurs.Title="Asp.NET";
    kurs.Description="Asp.NET using backend developing in web technology.";
   return View(kurs);
}
    public IActionResult List()
    {

        return View();
    }
}