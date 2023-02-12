using CvManagementMVC.Domain.Interfaces;
using CvManagementMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CvManagementMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICandidateAddressRepository, CandidateAddressRepository>();
            services.AddTransient<ICandidateContactRepository, CandidateContactRepository>();
            services.AddTransient<ICandidateRepository, CandidateRepository>();
            services.AddTransient<ICvRepository, CvRepository>();
            services.AddTransient<IEducationHistoryRepository, EducationHistoryRepository>();
            services.AddTransient<IEmploymentHistoryRepository, EmploymentHistoryRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
            
            return services;
        }
    }
}
