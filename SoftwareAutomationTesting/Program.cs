using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;

namespace SoftwareAutomationTesting
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}