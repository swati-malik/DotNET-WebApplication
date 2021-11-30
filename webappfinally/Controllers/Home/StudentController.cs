using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webappfinally.Model;

namespace webappfinally.Controllers.Home
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
            ViewBag.Message = "Student management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;

            return View();
        }
        public IActionResult Create()
        {
            

            return View();
        }
        public IActionResult Destroy()
        {


            return View();
        }
        public IActionResult Dest()
        {


            return View();
        }
        public IActionResult Destii()
        {


            return View();
        }
        public IActionResult Ready()
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
    }
}
