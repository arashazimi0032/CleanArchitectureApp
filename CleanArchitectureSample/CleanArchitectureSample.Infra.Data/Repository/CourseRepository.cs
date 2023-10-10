using CleanArchitectureSample.Domain.Interfaces;
using CleanArchitectureSample.Domain.Models;
using CleanArchitectureSample.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
