using CleanArchitectureSample.Application.Interfaces;
using CleanArchitectureSample.Application.ViewModels;
using CleanArchitectureSample.Domain.Commands;
using CleanArchitectureSample.Domain.Core.Bus;
using CleanArchitectureSample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name, 
                courseViewModel.Description, 
                courseViewModel.ImageUrl
                );

            _bus.SendCommand( createCourseCommand );
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses()};
        }
    }
}
