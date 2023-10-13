using CleanArchitectureSample.Application.Interfaces;
using CleanArchitectureSample.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);
            return Ok(courseViewModel);
        }
    }
}