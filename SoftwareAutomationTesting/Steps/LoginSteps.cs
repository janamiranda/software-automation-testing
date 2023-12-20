using SoftwareAutomationTesting.Pages;
using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;

namespace SoftwareAutomationTesting.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly NavigationHelper _navigationHelper;
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver webDriver, NavigationHelper navigationHelper, LoginPage loginPage)
        {
            _webDriver = webDriver;
            _navigationHelper = navigationHelper;
            _loginPage = loginPage;
        }

        [Given(@"the login page is displayed")]
        public void GivenTheLoginPageIsDisplayed()
        {
            _navigationHelper.GoToLoginPage(_webDriver);
        }

        [Given(@"the user ""(.*)"" is entered into the username field")]
        [Given(@"the correct user ""(.*)"" is entered into the username field")]
        public void GivenTheCorrectUserIsEnteredIntoTheUsernameField(string username)
        {
            _loginPage.EnterTextIntoRequiredTextBox("userName", username);
        }

        [Given(@"the password ""(.*)"" is entered into the password field")]
        [Given(@"the correct password ""(.*)"" is entered into the password field")]
        public void GivenTheCorrectPasswordIsEnteredIntoThePasswordField(string password)
        {
            _loginPage.EnterTextIntoRequiredTextBox("password", password);
        }

        [When(@"the user invokes the login action")]
        public void WhenTheUserInvokesTheLoginAction()
        {
            _loginPage.InvokeLoginAction();
        }

        [Then(@"the login is logged in successfully")]
        public void ThenTheLoginIsLoggedInSuccessfully()
        {
            _loginPage.WaitForLoginGoThrough();
            _loginPage.IsPartnerPortalPageDisplayed().Should().BeTrue();
        }

        [Then(@"the message ""(.*)"" is displayed")]
        public void ThenTheMessageIsDisplayed(string msg)
        {
            _loginPage.GetTextErrorMsgForInvalidCredentials().Should().Be(msg);
        }
    }
}
