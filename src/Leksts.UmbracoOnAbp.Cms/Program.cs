using Volo.Abp;

namespace Leksts.UmbracoOnAbp.Cms
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            await host.Services
                .GetRequiredService<IAbpApplicationWithExternalServiceProvider>()
                .InitializeAsync(host.Services);

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureUmbracoDefaults()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices(services =>
                {
                    services.AddApplicationAsync<UmbracoOnAbpCmsModule>(
                        options =>
                            options.Services.ReplaceConfiguration(services.GetConfiguration())
                    );
                })
                .UseLightInject()
                .UseAutofac();
    }
}
