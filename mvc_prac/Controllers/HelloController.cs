using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml.Linq;
using mvc_prac.Models;

namespace mvc_prac.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "hello world";
        //}

        //public IActionResult Index()
        //{
        //    return Content("Content hello world") ;
        //}

        public IActionResult Student() {
            Student student = new Student
            {
                Id = 1,
                Name = "xyz",
                Gender = "female",
            };
            return View(student);
        }


    }
}
