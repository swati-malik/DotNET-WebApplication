using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){StudentId=101, Name = "Kartik Sharma", city="Delhi",Gender="Male"},
            new Student(){StudentId=102, Name = "Shubham Sharma", city="Mumbai",Gender="Female"},
            new Student(){StudentId=103, Name = "Kartik Aryan", city="Ghaziabadi",Gender="Male"},
            new Student(){StudentId=104, Name = "Gautam Bhalla", city="Bangalore",Gender="Male"},
            new Student(){StudentId=105, Name = "King Kochar", city="Dheradun",Gender="Male"},
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;
            return View();
        }
        public IActionResult Details()
        {
            if (ViewBag.Message == null)
            {
                ViewBag.Message = "New Message";
            }
            else
            {
                ViewBag.NewMwssage = ViewBag.Message;
            }
            return View();

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Student management";
            ViewData["StudentCount"] = students.Count;
            ViewData["StudentList"] = students;
            return View();
        }
        public IActionResult Info()
        {
            TempData["Message"] = "Student management";
            TempData["StudentCount"] = students.Count;
            TempData["StudentList"] = students;
            return View();
        }
        public IActionResult RequestA()
        {
            TempData["Msg"] = "Hello World";
            return View();
        }
        public IActionResult RequestB()
        {
            if (TempData["Msg"] as string != null)
            {
                TempData["Msg"] = TempData["Msg"];
                return View();
            }
            else
            {


                return RedirectToAction("Index");
            }
        }
        public IActionResult StudentData()
        {
            return View(students);
        }
     }
}
