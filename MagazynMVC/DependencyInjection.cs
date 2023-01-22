using MagazynMVC.Interfaces;
using MagazynMVC.Services;

namespace MagazynMVC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IOilService, OilService>();

            return services;
        }
    }
}

