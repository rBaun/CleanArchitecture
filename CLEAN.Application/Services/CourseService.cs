using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler messageBus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _messageBus = messageBus;
            _autoMapper = autoMapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }

        public void CreateCourse(CourseViewModel courseViewModel)
        {
            _messageBus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }
    }
}
