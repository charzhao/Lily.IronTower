using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lily.Tools
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IronTowerManager>();
                })
                .Build();

            var serviceProvider = host.Services;


            using (host)
            {
                Console.WriteLine("Starting!");

                await host.StartAsync();

                var ironTowerManager = serviceProvider.GetService<IronTowerManager>();
                ironTowerManager.Handle();

                await host.StopAsync();

                Console.WriteLine("Stopped!");
            }
        }
    }
}
