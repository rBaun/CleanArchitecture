using System;
using System.Collections.Generic;
using System.Text;
using CLEAN.Application.Contracts;
using CLEAN.Application.Services;
using CLEAN.Domain.CommandHandlers;
using CLEAN.Domain.Commands;
using CLEAN.Domain.Core.MessageBus;
using CLEAN.Domain.Interfaces;
using CLEAN.Infrastructure.MessageBus;
using CLEAN.Infrastructure.Persistence.Context;
using CLEAN.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CLEAN.Infrastructure.IoC
{
    public class ServicesExtensions
    {
        public static void RegisterServices(IServiceCollection services)
        {
            AddDomainInMemoryBusMediatR(services);
            AddDomainHandlers(services);
            AddApplicationServices(services);
            AddPersistenceServices(services);
        }

        public static void AddDomainInMemoryBusMediatR(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
        }

        public static void AddDomainHandlers(IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();
        }

        private static void AddApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
        }

        private static void AddPersistenceServices(IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
        }
    }
}
