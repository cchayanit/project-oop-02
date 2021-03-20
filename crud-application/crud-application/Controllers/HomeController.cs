﻿using crud_application.Models;
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
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View(Repository.AllStudents);
        }

        public IActionResult About()
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

        public IActionResult Update(string empname)
        {
            Student student = Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault();
            return View(student);
        }


        [HttpPost]
        public IActionResult Update(Student student, string empname)
        {
            
            Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Age = student.Age;
            Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Year = student.Year;
            Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Major = student.Major;
            Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Sex = student.Sex;
            Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Name = student.Name;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(string empname)
        {
            Student student = Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault();
            Repository.Delete(student);
            return RedirectToAction("Index");
        }


        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
