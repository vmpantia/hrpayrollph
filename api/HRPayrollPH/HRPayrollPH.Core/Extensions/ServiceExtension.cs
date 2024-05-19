﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HRPayrollPH.Core.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCore(this IServiceCollection services) => 
            services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
                    .AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
