using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class AuthenticationPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.CssSelector, Using = "form#create-account_form")]
        private IWebElement _createAnAccountForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#email_create")]
        private IWebElement _createAnAccountFormEmailInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[name='SubmitCreate']")]
        private IWebElement _createAnAccountButton { get; set; }

        public void EnterUserEmail(string testEmail)
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountForm);
            _createAnAccountFormEmailInput.SendKeys(testEmail);
        }
        public void GoToRegistrationUserPage()
        {
            _createAnAccountButton.Click();
        }
    }
}
