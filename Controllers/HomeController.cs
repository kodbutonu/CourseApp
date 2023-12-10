﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;
using CourseApp.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }

   
}
