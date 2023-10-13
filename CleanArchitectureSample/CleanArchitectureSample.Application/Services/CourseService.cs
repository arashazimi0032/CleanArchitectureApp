using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            //return _autoMapper.ProjectTo<CourseViewModel>(_courseRepository.GetCourses());
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
