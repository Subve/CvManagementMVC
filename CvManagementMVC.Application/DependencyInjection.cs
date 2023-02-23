using AutoMapper;
using CvManagementMVC.Application.Interfaces;
using CvManagementMVC.Application.Services;
using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddTransient<ICandidateService, CandidateService>();
            services.AddTransient<ICandidateAddressService, AddressService>();
            services.AddTransient<ICvService, CvService>();
            services.AddTransient<ICandidateContactService, CandidateContactService>();
            services.AddTransient<IEducationHistoryRepository, EducationHistoryRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
