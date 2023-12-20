using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SoftwareAutomationTesting.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _webDriver;

        public SpecFlowHooks(ScenarioContext scenarioContext, IWebDriver webDriver)
        {
            _scenarioContext = scenarioContext;
            _webDriver = webDriver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            try
            {
                // Your existing BeforeScenario code...

                if (!_scenarioContext.ContainsKey("WebDriver"))
                {
                    _scenarioContext["WebDriver"] = _webDriver;
                }

                Console.WriteLine("WebDriver initialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing WebDriver: {ex.Message}");
                throw;
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            try
            {
                // Your existing AfterScenario code...

                _webDriver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning up WebDriver: {ex.Message}");
            }
        }
    }
}