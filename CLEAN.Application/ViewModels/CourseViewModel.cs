using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Domain.Models;

namespace CLEAN.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
