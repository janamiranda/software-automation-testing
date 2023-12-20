using OpenQA.Selenium;

namespace SoftwareAutomationTesting.Pages
{
    public class NavigationHelper
    {
        // URL of the login page
        private readonly string loginPageUrl = "https://dem-sis.spotzerstaging.com/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc34924aa-87b5-4316-99d7-75f3688db830%26redirect_uri%3Dhttps%253A%252F%252Fdem-portal.spotzerstaging.com%252FAccount%252FExternalLoginCallback%26response_type%3Dcode%2520id_token%26scope%3Dopenid%2520profile%26state%3DOpenIdConnect.AuthenticationProperties%253DENgK77GQoTLLcorEgjqST_V7eFeG39AJQ3AsLjou2ztaqf9FMds9Dmmt9u0Tt4l8PCS7LtDfrJPDNPYQY9k4_rW3N1X1p9szo0dWZl5VYcpzWIL91X9xuuxw0R-131eNoF64mSGFA2qFVxLZF2dTAw1eY1KNj5IQ4OvN2sIqZvAsTDycdu1PhFPpM8J_pdYLoimLQWaRpkihPjoUGzjOoUXXbxka-br8b_ZsMNkBCjWBELEXbAMXNP0wQT4k_9kvo2rca2hXgRc0wCaRCul_6JLR6fpWeErgdXcDOjJCjVwMxLScHUsciOGqlJ-Vi9pkQ47GrT5cPTK0tIkZB1BZXOs2NElbDEqzYWZ7HoMZGSA%26response_mode%3Dform_post%26nonce%3D638384375024397656.NjQyMWVhMGMtOWZiMC00MGVlLWE0NTMtMGQwZWIzZTQ4OWNhZGYwZmU3NzMtNTIzNi00N2FhLTgxZWMtZTY4NjJlMGM3ZTRm%26x-client-SKU%3DID_NET472%26x-client-ver%3D6.29.0.0";

        // Navigates to the specified URL using the provided WebDriver
        private void GoToSpecifiedUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        // Public method to navigate to the login page
        public void GoToLoginPage(IWebDriver driver)
        {
            // Calls the private method to navigate to the login page URL
            GoToSpecifiedUrl(driver, loginPageUrl);
        }
    }
}
