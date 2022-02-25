using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class MainPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _signInButton = By.CssSelector("a.login");

        public MainPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }
        public AuthenticationPageObject GoToAuthenticationPage()
        {
            chromeDriver.FindElement(_signInButton).Click();
            return new AuthenticationPageObject(chromeDriver);
        }
    }
}
