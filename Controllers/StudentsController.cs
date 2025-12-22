using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;
using System.Collections.Generic;

namespace MvcDemo.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            students.Add(s);
            return RedirectToAction("Index");
        }
    }
}
