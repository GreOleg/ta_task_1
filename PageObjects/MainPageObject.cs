using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class MainPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.CssSelector, Using = "a.login")]
        private IWebElement _signInButton { get; set; }
        public void GoToAuthenticationPage()
        {
            _signInButton.Click();
        }
    }
}
