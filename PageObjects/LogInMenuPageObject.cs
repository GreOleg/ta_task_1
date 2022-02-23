using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class LogInMenuPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _createAnAccountForm = By.CssSelector("form#create-account_form");
        private readonly By _createAnAccountFormEmailInput = By.CssSelector("input#email_create");
        private readonly By _createAnAccountButton = By.CssSelector("button[name='SubmitCreate']");
        //private readonly By _createAccountError = By.XPath("//div[@id='create_account_error']");
        private readonly By _signInFormEmailInput = By.CssSelector("input#email");
        private readonly By _signInFormPasswordInput = By.CssSelector("input#passwd");
        private readonly By _signInFormSubmitButton = By.CssSelector("button#SubmitLogin");

        public LogInMenuPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public MyAccountPageObject LogIn(string email, string password)
        {
            chromeDriver.FindElement(_signInFormEmailInput).SendKeys(email);

            chromeDriver.FindElement(_signInFormPasswordInput).SendKeys(password);

            chromeDriver.FindElement(_signInFormSubmitButton).Click();

            return new MyAccountPageObject(chromeDriver);
        }

        public RegistrationUserPageObject Registration(string email)
        {

            WaitUntil.WaitElement(chromeDriver, _createAnAccountForm);

            chromeDriver.FindElement(_createAnAccountFormEmailInput).SendKeys(email);

            chromeDriver.FindElement(_createAnAccountButton).Click();

            //WaitUntil.WaitElement(chromeDriver, _createAccountError);

            return new RegistrationUserPageObject(chromeDriver);
        }
    }
}
