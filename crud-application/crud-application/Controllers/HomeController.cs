using crud_application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace crud_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Repository.AllStudents);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Student student)
        {
            Repository.Create(student);
            return View("Thanks", student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
