using System;
using System.Collections.Generic;
using System.Text;
using Leksts.UmbracoOnAbp.Localization;
using Volo.Abp.Application.Services;

namespace Leksts.UmbracoOnAbp;

/* Inherit your application services from this class.
 */
public abstract class UmbracoOnAbpAppService : ApplicationService
{
    protected UmbracoOnAbpAppService()
    {
        LocalizationResource = typeof(UmbracoOnAbpResource);
    }
}
