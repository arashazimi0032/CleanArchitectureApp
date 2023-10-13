using CleanArchitectureSample.Application.Interfaces;
using CleanArchitectureSample.Application.Services;
using CleanArchitectureSample.Domain.CommandHandlers;
using CleanArchitectureSample.Domain.Commands;
using CleanArchitectureSample.Domain.Core.Bus;
using CleanArchitectureSample.Domain.Interfaces;
using CleanArchitectureSample.Infra.Bus;
using CleanArchitectureSample.Infra.Data.Context;
using CleanArchitectureSample.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();
        }
    }
}
