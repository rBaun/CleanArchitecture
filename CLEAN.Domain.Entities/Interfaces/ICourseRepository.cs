using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Domain.Models;

namespace CLEAN.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
