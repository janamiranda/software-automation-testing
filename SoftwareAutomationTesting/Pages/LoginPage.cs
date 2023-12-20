using OpenQA.Selenium;
using NLog;
using OpenQA.Selenium.Support.UI;

namespace SoftwareAutomationTesting.Pages
{
    public class LoginPage
    {
        // Logger for logging information and errors
        private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        // WebDriver instance for interacting with the web page
        private IWebDriver driver;

        // WebDriverWait for waiting for elements to be present in the DOM when needed
        private WebDriverWait wait;

        // Constructor to initialize the LoginPage with a WebDriver instance
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Properties to represent various elements on the login page
        private IWebElement UserNameTextBox => driver.FindElement(By.Id("Username"));
        private IWebElement PasswordTextBox => driver.FindElement(By.Id("Password"));
        private IWebElement LoginBtn => driver.FindElement(By.XPath("[class='form-group'] [value='login']"));
        private IWebElement InvalidCredentialsErrorMessage => driver.FindElement(By.XPath("[class='danger validation-summary-errors']"));
        private IWebElement PartnerPage => driver.FindElement(By.Id("partnerName"));

        // Method to enter text into the specified text box based on its name
        public void EnterTextIntoRequiredTextBox(string userNameOrPassword, string text)
        {
            _logger.Info($"Entering {text} into {userNameOrPassword} element");
            if (userNameOrPassword.Equals("userName"))
            {
                UserNameTextBox.SendKeys(text);
            }
            else
            {
                PasswordTextBox.SendKeys(text);
            }
        }

        // Method to click the login button
        public void InvokeLoginAction()
        {
            LoginBtn.Click();
        }

        // Method to wait until the login process completes
        public void WaitForLoginGoThrough()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("[class='form-group'] [value='login']")));
        }

        // Method to get the error message displayed for invalid credentials
        public string GetTextErrorMsgForInvalidCredentials()
        {
            var errorMsg = InvalidCredentialsErrorMessage.Text;
            return errorMsg;
        }

        // Method to check if the Partner Portal page is displayed
        public bool IsPartnerPortalPageDisplayed()
        {
            return PartnerPage.Displayed;
        }
    }
}
