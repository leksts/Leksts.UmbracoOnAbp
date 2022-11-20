using Leksts.UmbracoOnAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Leksts.UmbracoOnAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class UmbracoOnAbpController : AbpControllerBase
{
    protected UmbracoOnAbpController()
    {
        LocalizationResource = typeof(UmbracoOnAbpResource);
    }
}
