using Leksts.UmbracoOnAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Leksts.UmbracoOnAbp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class UmbracoOnAbpPageModel : AbpPageModel
{
    protected UmbracoOnAbpPageModel()
    {
        LocalizationResourceType = typeof(UmbracoOnAbpResource);
    }
}
