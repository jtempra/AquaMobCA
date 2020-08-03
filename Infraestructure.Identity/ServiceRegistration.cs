using Application.Interfaces;
using Infraestructure.Identity.Contexts;
using Infraestructure.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Identity
{
    public static class ServiceRegistration
    {
        public static void AddIdentityInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IdentityContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("IdentityConnection"),
                    b => b.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

            services.AddTransient<IAccountService, AccountService>();

        }
    }
}
