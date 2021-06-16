using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLEAN.Domain.Interfaces;
using CLEAN.Domain.Models;
using CLEAN.Infrastructure.Persistence.Context;

namespace CLEAN.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public IQueryable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }

        public void Add(Course course)
        {
            _universityDbContext.Courses.Add(course);
            _universityDbContext.SaveChanges();
        }
    }
}
