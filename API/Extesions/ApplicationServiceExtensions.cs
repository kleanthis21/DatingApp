using API.Data;
using API.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using API.Services;

namespace API.Extesions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services ,IConfiguration config) 
        {
            services.AddScoped<ITokenService,TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));     
            });

            return services;
        }
    }
}