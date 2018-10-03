using Allegro.Framework.Api;
using Allegro.Framework.Swagger;
using Allegro.Template.Data;
using Allegro.Template.Data.Repositories;
using Allegro.Template.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Allegro.Template.Api
{
    public sealed class Startup : WebApiRegistration
    {
        public Startup(IConfiguration configuration) : base(configuration) { }

        //required for DI app.UseAuthentication();
        public override void DependencyContainer(IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SampleDataContext>(opt => opt.UseSqlServer(connection));

            services.AddScoped<ISampleDataRepository, SampleDataRepository>();
        }

        //required to find the location of controllers
        public override Dictionary<AssemblyType, Assembly> GetAssemblies()
        {
            return new Dictionary<AssemblyType, Assembly>
            {
                { AssemblyType.Controller, typeof(Controller.Registration).Assembly }
            };
        }

        //optional CAN BE REMOVE if we need to change configuration of swagger
        public override SwaggerRegistration SwaggerRegistration()
        {
            return base.SwaggerRegistration();
        }

        //optional CAN BE REMOVE if we need to disable authorization
        public override bool EnableAuthoriztion() { return true; }
    }


}
