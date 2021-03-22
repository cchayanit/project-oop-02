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

                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Name = student.Name;
                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Age = student.Age;
                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Year = student.Year;
                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Major = student.Major;
                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Gender = student.Gender;
                Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault().Subject = student.Subject;

                return RedirectToAction("Index");
        
        }

        [HttpPost]
    public IActionResult Delete(string empname)
    {
        Student student = Repository.AllStudents.Where(e => e.Name == empname).FirstOrDefault();
        Repository.Delete(student);
        return RedirectToAction("Index");
    }

   
    }
}
