using Allegro.Template.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Allegro.Template.Data
{
    public class SampleDataContext : DbContext
    {
        public SampleDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SampleDataModel> SampleDataModel { get; set; }

    }
}
