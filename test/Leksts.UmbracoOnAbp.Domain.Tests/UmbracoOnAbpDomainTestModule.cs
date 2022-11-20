using Leksts.UmbracoOnAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Leksts.UmbracoOnAbp;

[DependsOn(
    typeof(UmbracoOnAbpEntityFrameworkCoreTestModule)
    )]
public class UmbracoOnAbpDomainTestModule : AbpModule
{

}
