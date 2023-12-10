using basics.Models;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult List()
    {
      
        return View("List",Repository.Courses);
    }
   public IActionResult Details(int? id)
{
    if (id == null)
    {
        return RedirectToAction("List", "Course");
    }

    // Assuming Repository.GetById accepts int as argument
    var kurs = Repository.GetById(id.Value);

    if (kurs == null)
    {
        return NotFound(); // or handle the case where the item is not found
    }

    return View(kurs);
}

}