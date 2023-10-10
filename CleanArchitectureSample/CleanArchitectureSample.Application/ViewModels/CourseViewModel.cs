using CleanArchitectureSample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Application.ViewModels
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
