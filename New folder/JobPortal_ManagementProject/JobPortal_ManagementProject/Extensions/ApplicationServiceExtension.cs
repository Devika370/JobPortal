using DomainJobPortal.Models;
using DomainJobPortal.Services;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_ManagementProject.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobPortalApplicationDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            

            return services;

        }
    }
}
