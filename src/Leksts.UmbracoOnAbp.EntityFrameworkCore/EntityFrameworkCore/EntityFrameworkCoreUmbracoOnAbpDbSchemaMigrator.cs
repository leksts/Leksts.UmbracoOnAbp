using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Leksts.UmbracoOnAbp.Data;
using Volo.Abp.DependencyInjection;

namespace Leksts.UmbracoOnAbp.EntityFrameworkCore;

public class EntityFrameworkCoreUmbracoOnAbpDbSchemaMigrator
    : IUmbracoOnAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreUmbracoOnAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the UmbracoOnAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<UmbracoOnAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
