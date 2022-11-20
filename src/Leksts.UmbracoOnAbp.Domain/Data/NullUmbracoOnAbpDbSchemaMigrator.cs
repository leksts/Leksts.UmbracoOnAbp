using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Leksts.UmbracoOnAbp.Data;

/* This is used if database provider does't define
 * IUmbracoOnAbpDbSchemaMigrator implementation.
 */
public class NullUmbracoOnAbpDbSchemaMigrator : IUmbracoOnAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
