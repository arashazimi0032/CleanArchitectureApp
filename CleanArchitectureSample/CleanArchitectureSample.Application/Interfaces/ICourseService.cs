using CleanArchitectureSample.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
