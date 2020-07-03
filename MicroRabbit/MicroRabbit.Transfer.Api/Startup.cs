using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Transfer.Api.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Swagger configration setup
            SwaggerSetup.AddSwaggerSetup(services);

            //EntityFrmework configuration setup
            EntityFrameworkSetup.AddEntityFrameworkSetup(services, Configuration);

            //Mediator configration setup
            MediatorSetup.AddMediatorSettup(services);

            //Dependency Injection
            DependencyInjection.Register(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Swagger configration setup
            SwaggerSetup.UseSwaggerSetup(app);

            //EventBus configuration setup
            EventBusSetup.UseEventBusSetup(app);
        }
    }
}
