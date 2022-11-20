using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Leksts.UmbracoOnAbp;

public class DemoAppService : ApplicationService, IDemoAppService
{
    public Task<int> GetTheAnswer(CancellationToken cancellationToken)
    {
        return Task.FromResult(42);
    }
}
