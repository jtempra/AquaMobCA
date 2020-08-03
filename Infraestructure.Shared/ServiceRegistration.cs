using Application.Interfaces;
using Domain.Settings;
using Infraestructure.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfraestructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<EMailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
