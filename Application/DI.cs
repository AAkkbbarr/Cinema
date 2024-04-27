using Application.Services;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application   
{
    public class DI
    {
        public DI()
        {
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Cinema>, CinemaService>();

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
