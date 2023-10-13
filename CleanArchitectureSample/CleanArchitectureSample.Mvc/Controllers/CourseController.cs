using CleanArchitectureSample.Application.Interfaces;
using CleanArchitectureSample.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSample.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            return View(_courseService.GetCourses());
        }
    }
}
