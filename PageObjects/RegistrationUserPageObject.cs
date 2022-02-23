using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ta_task_1.PageObjects
{
    internal class RegistrationUserPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _createAnAccountFormPersonalInformationForm = By.CssSelector("form#account-creation_form");
        private readonly By _createAnAccountFormPersonalInformationTitleRadio = By.CssSelector("input#id_gender1");
        private readonly By _createAnAccountFormPersonalInformationFirstName = By.CssSelector("input#customer_firstname");
        private readonly By _createAnAccountFormPersonalInformationLastName = By.CssSelector("input#customer_lastname");
        private readonly By _createAnAccountFormPersonalInformationPasswword = By.CssSelector("input#passwd");
        private readonly By _createAnAccountFormPersonalInformationDateOfBirthDay = By.CssSelector("select#days");
        private readonly By _createAnAccountFormPersonalInformationDateOfBirthMonth = By.CssSelector("select#months");
        private readonly By _createAnAccountFormPersonalInformationDateOfBirthYear = By.CssSelector("select#years");
        private readonly By _createAnAccountFormPersonalInformationCheckboxNewsletter = By.CssSelector("input#newsletter");
        private readonly By _createAnAccountFormYourAddressAddress = By.CssSelector("input#address1");
        private readonly By _createAnAccountFormYourAddressCity = By.CssSelector("input#city");
        private readonly By _createAnAccountFormYourAddressState = By.CssSelector("select#id_state");
        private readonly By _createAnAccountFormYourAddressPostCode = By.CssSelector("input#postcode");
        private readonly By _createAnAccountFormYourAddressMobilePhone = By.CssSelector("input#phone_mobile");
        private readonly By _createAnAccountFormSubmitAccount = By.CssSelector("button#submitAccount");

        public RegistrationUserPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public MyAccountPageObject RegistrationUser(
            string firstName, 
            string lastName,
            string password,
            string dayBirthValue,
            string monthBirthValue,
            string yearBirthValue,
            string address,
            string city,
            string state,
            string posteCode,
            string mobilePhone
            )
        {

            WaitUntil.WaitElement(chromeDriver, _createAnAccountFormPersonalInformationForm);

            chromeDriver.FindElement(_createAnAccountFormPersonalInformationTitleRadio).Click();

            chromeDriver.FindElement(_createAnAccountFormPersonalInformationFirstName).SendKeys(firstName);

            chromeDriver.FindElement(_createAnAccountFormPersonalInformationLastName).SendKeys(lastName);

            chromeDriver.FindElement(_createAnAccountFormPersonalInformationPasswword).SendKeys(password);

            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthDay)).SelectByValue(dayBirthValue);

            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthMonth)).SelectByValue(monthBirthValue);

            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthYear)).SelectByValue(yearBirthValue);

            chromeDriver.FindElement(_createAnAccountFormPersonalInformationCheckboxNewsletter).Click();

            chromeDriver.FindElement(_createAnAccountFormYourAddressAddress).SendKeys(address);

            chromeDriver.FindElement(_createAnAccountFormYourAddressCity).SendKeys(city);

            new SelectElement(chromeDriver.FindElement(_createAnAccountFormYourAddressState)).SelectByValue(state);

            chromeDriver.FindElement(_createAnAccountFormYourAddressPostCode).SendKeys(posteCode);

            chromeDriver.FindElement(_createAnAccountFormYourAddressMobilePhone).SendKeys(mobilePhone);

            chromeDriver.FindElement(_createAnAccountFormSubmitAccount).Click();

            return new MyAccountPageObject(chromeDriver);
        }
    }
}
