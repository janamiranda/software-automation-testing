using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SoftwareAutomationTesting.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public SpecFlowHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            try
            {
                // Specify the path to the ChromeDriver executable
                var chromeDriverPath = @"C:\Users\janam\OneDrive\Área de Trabalho\chromejana\chromedriver-win64";

                // Initialize ChromeDriver with options, if needed
                var options = new ChromeOptions();
                options.AddArgument("start-maximized"); // Example option, add others as needed
                var driverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);

                _driver = new ChromeDriver(driverService, options);

                // Maximize the browser window
                _driver.Manage().Window.Maximize();

                // Set the WebDriver instance in the SpecFlow context
                _scenarioContext.Set(_driver); // The key is inferred from the type

                Console.WriteLine("WebDriver initialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing WebDriver: {ex.Message}");
                // Log the exception or handle it as appropriate for your scenario
                throw; // Rethrow the exception to fail the scenario
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            try
            {
                // Your cleanup code here
                // Close and quit the WebDriver
                _driver?.Quit();
            }
            // Handle exception
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning up WebDriver: {ex.Message}");
            }
        }
    }
}
