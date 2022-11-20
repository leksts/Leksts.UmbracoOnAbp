using Leksts.UmbracoOnAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Leksts.UmbracoOnAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(UmbracoOnAbpEntityFrameworkCoreModule),
    typeof(UmbracoOnAbpApplicationContractsModule)
    )]
public class UmbracoOnAbpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
