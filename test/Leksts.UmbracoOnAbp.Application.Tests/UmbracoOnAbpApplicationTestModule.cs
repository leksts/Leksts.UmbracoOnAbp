using Volo.Abp.Modularity;

namespace Leksts.UmbracoOnAbp;

[DependsOn(
    typeof(UmbracoOnAbpApplicationModule),
    typeof(UmbracoOnAbpDomainTestModule)
    )]
public class UmbracoOnAbpApplicationTestModule : AbpModule
{

}
