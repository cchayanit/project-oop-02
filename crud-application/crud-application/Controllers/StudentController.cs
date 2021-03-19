using crud_application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_application.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
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
            return View("Thanks",student);
        }
    }
}
