using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLEAN.Application.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace CLEAN.Presentation.MVC.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var model = _courseService.GetCourses();

            return View(model);
        }
    }
}
