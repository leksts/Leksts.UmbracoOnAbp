using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Leksts.UmbracoOnAbp.Web;

[Dependency(ReplaceServices = true)]
public class UmbracoOnAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "UmbracoOnAbp";
}
