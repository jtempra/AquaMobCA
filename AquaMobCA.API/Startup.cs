using API;
using API.Middlewares;
using Application;
using AutoMapper;
using Infraestructure.Identity;
using Infraestructure.Persistence;
using Infraestructure.Shared;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AquaMobCA.API
{
    public class Startup
    {
        public IConfiguration _config { get; }

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR();

            services.AddAutoMapper();

            services.AddValidations();

            services.AddIdentityInfraestructure(_config);

            services.AddPersistenceInfraestructure(_config);

            services.AddSharedInfraestructure(_config);

            services.AddSwagger();

            services.AddControllers();


        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
                //c.RoutePrefix = string.Empty;
            });

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
