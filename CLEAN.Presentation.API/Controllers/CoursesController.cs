using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLEAN.Application.Contracts;
using CLEAN.Application.ViewModels;

namespace CLEAN.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.CreateCourse(courseViewModel);

            return Ok(courseViewModel);
        }
    }
}
