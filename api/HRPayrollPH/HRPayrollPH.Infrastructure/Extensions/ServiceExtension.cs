using HRPayrollPH.Domain.Contractors.Repositories;
using HRPayrollPH.Infrastructure.Databases.Contexts;
using HRPayrollPH.Infrastructure.Databases.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HRPayrollPH.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<HRPayrollPHDbContext>(context => context.UseSqlServer(configuration.GetConnectionString("MigrationDb")))
                    .AddScoped<IEmployeeRepository, EmployeeRepository>();
    }
}
