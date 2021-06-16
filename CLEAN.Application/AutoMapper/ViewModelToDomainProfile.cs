using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CLEAN.Application.ViewModels;
using CLEAN.Domain.Commands;

namespace CLEAN.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
