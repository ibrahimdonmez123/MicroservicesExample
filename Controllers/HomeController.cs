using MicroservicesExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microservices.Students;
using Microservices.Lessons;

namespace MicroservicesExample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly StudentService _studentService;
        private readonly LessonService _lessonService;

        public HomeController(StudentService studentService, LessonService lessonService)
        {
            _studentService = studentService;
            _lessonService = lessonService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowStudentList()
        {
            var students = _studentService.GetStudents();
            return View(students);
        }

        public IActionResult ShowLessonList()
        {
            var lessons = _lessonService.GetLessons();
            return View(lessons);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}