using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SoftwareAutomationTesting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register IWebDriver as a singleton
            services.AddSingleton<IWebDriver>(provider =>
            {
                var chromeDriverPath = @"C:\Users\janam\OneDrive\Área de Trabalho\chromejana\chromedriver-win64";
                var options = new ChromeOptions();
                options.AddArgument("start-maximized");

                var driverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);
                var driver = new ChromeDriver(driverService, options);

                return driver;
            });

            // Other service registrations...
        }
    }
}
