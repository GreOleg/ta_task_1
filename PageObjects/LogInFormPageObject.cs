using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class LogInFormPageObject
    {
        [FindsBy(How = How.CssSelector, Using = "input#email")]
        private IWebElement _signInFormEmailInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#passwd")]
        private IWebElement _signInFormPasswordInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button#SubmitLogin")]
        private IWebElement _signInFormSubmitButton { get; set; }

        public void SubmitLogInForm(string email, string password)
        {
            _signInFormEmailInput.SendKeys(email);
            _signInFormPasswordInput.SendKeys(password);
            _signInFormSubmitButton.Click();
        }
    }
}
