using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace CLEAN.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappers()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new ViewModelToDomainProfile());
                config.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
