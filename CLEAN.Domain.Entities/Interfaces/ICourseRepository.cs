using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLEAN.Domain.Models;

namespace CLEAN.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}
