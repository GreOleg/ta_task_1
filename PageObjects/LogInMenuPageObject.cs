using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ta_task_1.PageObjects
{
    class LogInMenuPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _createAnAccountForm = By.CssSelector("form#create-account_form");
        private readonly By _createAnAccountFormEmailInput = By.CssSelector("input#email_create");
        private readonly By _createAnAccountButton = By.CssSelector("button[name='SubmitCreate']");
        private readonly By _createAccountError = By.XPath("//div[@id='create_account_error']");

        public LogInMenuPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public RegistrationUserPageObject LogIn(string email)
        {
            //new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10))
            //    .Until(drv => drv.FindElement(_createAnAccountForm));
            WaitUntil.WaitElement(chromeDriver, _createAnAccountForm);

            chromeDriver.FindElement(_createAnAccountFormEmailInput).SendKeys(email);

            chromeDriver.FindElement(_createAnAccountButton).Click();

            var createAccountError = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10))
                .Until(drv => drv.FindElement(_createAccountError));

            //if (createAccountError.Displayed)
            //{
            //    chromeDriver.FindElement(_signInFormEmailInput).SendKeys(email);

            //    chromeDriver.FindElement(_signInFormPasswordInput).SendKeys(password);

            //    chromeDriver.FindElement(_signInFormSubmitButton).Click();

            //    return new MyAccountPageObject(chromeDriver);
            //} 

            return new RegistrationUserPageObject(chromeDriver);
        }
    }
}
