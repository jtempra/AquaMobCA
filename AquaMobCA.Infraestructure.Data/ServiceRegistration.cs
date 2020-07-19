using Application.Interfaces;
using Infraestructure.Persistence.DataContext;
using Infraestructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            // registrem el contexte

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            // registrem el repo

            services.AddTransient(typeof(IGenericRepoAsync<>), typeof(GenericRepoAsync<>));
        }
    }
}
