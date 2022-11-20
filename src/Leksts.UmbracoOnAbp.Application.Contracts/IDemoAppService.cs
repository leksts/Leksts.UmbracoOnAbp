using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Leksts.UmbracoOnAbp;

public interface IDemoAppService : IApplicationService
{
    public Task<int> GetTheAnswer(CancellationToken cancellationToken);
}
