using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CLEAN.Application.ViewModels;
using CLEAN.Domain.Commands;
using CLEAN.Domain.Models;

namespace CLEAN.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
