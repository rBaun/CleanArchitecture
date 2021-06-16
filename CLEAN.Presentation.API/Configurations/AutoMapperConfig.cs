using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLEAN.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CLEAN.Presentation.API.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappers();
        }
    }
}
