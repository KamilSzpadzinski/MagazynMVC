using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MagazynMVC.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MagazynDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MagazynDb")));

            return services;
        }
    }
}
