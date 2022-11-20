using Volo.Abp.Modularity;

namespace Leksts.UmbracoOnAbp.Cms;

[DependsOn(typeof(UmbracoOnAbpHttpApiClientModule))]
public class UmbracoOnAbpCmsModule : AbpModule { }
