using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using NaotTLR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaotTLR.Application
{
    public static class ServiceInjector
    {
        public static IServiceCollection AddApplicationEvents(this IServiceCollection services)
        {
            //services.AddScoped<>();
            return services;
        }
    }
}
