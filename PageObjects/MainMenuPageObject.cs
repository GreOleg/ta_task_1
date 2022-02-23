using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _signInButton = By.CssSelector("a.login");
        //private readonly By _signOutButton = By.XPath("//a[@title='Log me out']");


        public MainMenuPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public LogInMenuPageObject SignIn ()
        {
            chromeDriver.FindElement(_signInButton).Click();

            return new LogInMenuPageObject(chromeDriver);
        }

        //public LogInMenuPageObject SignOut ()
        //{
        //    chromeDriver.FindElement(_signOutButton).Click();

        //    return new LogInMenuPageObject(chromeDriver);
        //}
    }
}
