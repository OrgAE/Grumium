using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OrgAE.Grumium.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class GrumiumMigrationsDbContextFactory : IDesignTimeDbContextFactory<GrumiumMigrationsDbContext>
    {
        public GrumiumMigrationsDbContext CreateDbContext(string[] args)
        {
            GrumiumEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<GrumiumMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new GrumiumMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OrgAE.Grumium.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
