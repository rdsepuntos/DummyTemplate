using Allegro.Template.Data;
using Allegro.Template.Data.Repositories;
using Allegro.Template.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Allegro.Template.Api
{
    public static class DependencyContainer
    {
        public static void ConfigureContainer(IServiceCollection services, IConfiguration configuration)
        {
            //connectionString
            var connection = configuration.GetConnectionString("DefaultConnection");

            //database
            services.AddDbContext<SampleDataContext>(opt => opt.UseSqlServer(connection));

            //injection
            services.AddScoped<ISampleDataRepository, SampleDataRepository>();
        }

    }
}
