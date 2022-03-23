using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class CreateAnAccountFormPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.CssSelector, Using = "form#create-account_form")]
        private IWebElement _createAnAccountForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#email_create")]
        private IWebElement _createAnAccountFormEmailInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[name='SubmitCreate']")]
        private IWebElement _createAnAccountButton { get; set; }

        public void SubmitCreateAnAcountForm(Person person)
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountForm);
            _createAnAccountFormEmailInput.SendKeys(person.emailUser);
            _createAnAccountButton.Click();
        }
    }
}
