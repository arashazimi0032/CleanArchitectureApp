using CleanArchitectureSample.Domain.Commands;
using CleanArchitectureSample.Domain.Interfaces;
using CleanArchitectureSample.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
