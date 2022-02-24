using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _signInButton = By.CssSelector("a.login");

        public MainMenuPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public LogInMenuPageObject GoToLogInPage()
        {
            chromeDriver.FindElement(_signInButton).Click();

            return new LogInMenuPageObject(chromeDriver);
        }
    }
}
