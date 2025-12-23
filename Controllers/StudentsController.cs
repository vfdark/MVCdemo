using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

public class StudentsController : Controller
{
    static List<Student> students = new List<Student>()
    {
        new Student { Id = 1, Name = "Ali", Age = 20 },
        new Student { Id = 2, Name = "Sara", Age = 22 }
    };

    public IActionResult Index()
    {
        return View(students);
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        student.Id = students.Count + 1;
        students.Add(student);
        return RedirectToAction("Index");
    }

    // 🔴 DELETE
    public IActionResult Delete(int id)
    {
        var student = students.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
        }
        return RedirectToAction("Index");
    }
}
