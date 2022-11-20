using System.Threading.Tasks;

namespace Leksts.UmbracoOnAbp.Data;

public interface IUmbracoOnAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
