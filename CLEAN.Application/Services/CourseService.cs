using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Application.Contracts;
using CLEAN.Application.ViewModels;
using CLEAN.Domain.Interfaces;

namespace CLEAN.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
