using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Leksts.UmbracoOnAbp;

public class UmbracoOnAbpWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<UmbracoOnAbpWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
