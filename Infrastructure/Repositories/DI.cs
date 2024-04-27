using Application.Commons;
using AutoMapper.Configuration;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApplicationDbInitialize, ApplicationDbInitialize>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddDbContext<ApplicationDBContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                //if (configuration["UseInMemoryDatabase"] == "true")
                //    options.UseInMemoryDatabase("testDb");
                //else
                options.UseNpgsql(connectionString);
            });

            return services;
        }
    }
}
