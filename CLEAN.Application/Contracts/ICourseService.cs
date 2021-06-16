using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Application.ViewModels;

namespace CLEAN.Application.Contracts
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void CreateCourse(CourseViewModel courseViewModel);
    }
}
