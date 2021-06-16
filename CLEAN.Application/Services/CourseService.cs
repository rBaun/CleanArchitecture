using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Application.Contracts;
using CLEAN.Application.ViewModels;
using CLEAN.Domain.Commands;
using CLEAN.Domain.Core.MessageBus;
using CLEAN.Domain.Interfaces;

namespace CLEAN.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _messageBus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler messageBus)
        {
            _courseRepository = courseRepository;
            _messageBus = messageBus;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name, 
                courseViewModel.Description, 
                courseViewModel.ImageUrl);

            _messageBus.SendCommand(createCourseCommand);
        }
    }
}
