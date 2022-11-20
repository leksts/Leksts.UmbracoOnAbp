using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Leksts.UmbracoOnAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class UmbracoOnAbpDbContextFactory : IDesignTimeDbContextFactory<UmbracoOnAbpDbContext>
{
    public UmbracoOnAbpDbContext CreateDbContext(string[] args)
    {
        UmbracoOnAbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<UmbracoOnAbpDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new UmbracoOnAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Leksts.UmbracoOnAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
