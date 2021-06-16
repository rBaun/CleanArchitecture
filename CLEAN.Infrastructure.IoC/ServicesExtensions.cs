using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Application.Contracts;
using CLEAN.Application.Services;
using CLEAN.Domain.Interfaces;
using CLEAN.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CLEAN.Infrastructure.IoC
{
    public class ServicesExtensions
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddApplicationServices(services);
            AddPersistenceServices(services);
        }

        private static void AddApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
        }

        private static void AddPersistenceServices(IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
