namespace Leksts.UmbracoOnAbp.Cms.Controllers;

using Umbraco.Cms.Web.Common.Controllers;

public class DemoController : UmbracoApiController
{
    private readonly IDemoAppService service;

    public DemoController(IDemoAppService service)
    {
        this.service = service;
    }

    public async Task<int> GetTheAnswer(CancellationToken cancellationToken)
    {
        return await this.service.GetTheAnswer(cancellationToken);
    }
}
