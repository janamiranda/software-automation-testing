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
                // Insert personal chromeDriverPath
                var chromeDriverPath = @"C:\Users\janam\OneDrive\Área de Trabalho\chromejana\chromedriver-win64";
                var options = new ChromeOptions();
                options.AddArgument("start-maximized");

                var driverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);
                return new ChromeDriver(driverService, options);
            });

            // Register NavigationHelper and LoginPage as transient
            services.AddTransient<SoftwareAutomationTesting.Pages.NavigationHelper>();
            services.AddTransient<SoftwareAutomationTesting.Pages.LoginPage>();

            services.AddTransient<SoftwareAutomationTesting.Steps.LoginSteps>();

            // Register SpecFlowHooks with ScenarioContext as a transient
            services.AddTransient<SoftwareAutomationTesting.Hooks.SpecFlowHooks>();

            // Other service registrations...
        }
    }
}
