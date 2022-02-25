using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace ta_task_1.PageObjects
{
    class RegistrationUserPageObject
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

        public MyAccountPageObject RegistrationUser(Dictionary<string, string> user)
        {
            WaitUntil.WaitElement(chromeDriver, _createAnAccountFormPersonalInformationForm);
            chromeDriver.FindElement(_createAnAccountFormPersonalInformationTitleRadio).Click();
            chromeDriver.FindElement(_createAnAccountFormPersonalInformationFirstName).SendKeys(user["firstNameUser"]);
            chromeDriver.FindElement(_createAnAccountFormPersonalInformationLastName).SendKeys(user["lastNameUser"]);
            chromeDriver.FindElement(_createAnAccountFormPersonalInformationPasswword).SendKeys(user["passwordUser"]);
            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthDay)).SelectByValue(user["dayBirthUser"]);
            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthMonth)).SelectByValue(user["monthBirthUser"]);
            new SelectElement(chromeDriver.FindElement(_createAnAccountFormPersonalInformationDateOfBirthYear)).SelectByValue(user["yearBirthUser"]);
            chromeDriver.FindElement(_createAnAccountFormPersonalInformationCheckboxNewsletter).Click();
            chromeDriver.FindElement(_createAnAccountFormYourAddressAddress).SendKeys(user["addressUser"]);
            chromeDriver.FindElement(_createAnAccountFormYourAddressCity).SendKeys(user["cityUser"]);
            new SelectElement(chromeDriver.FindElement(_createAnAccountFormYourAddressState)).SelectByValue(user["stateUser"]);
            chromeDriver.FindElement(_createAnAccountFormYourAddressPostCode).SendKeys(user["postCodeUser"]);
            chromeDriver.FindElement(_createAnAccountFormYourAddressMobilePhone).SendKeys(user["mobilePhoneUser"]);
            chromeDriver.FindElement(_createAnAccountFormSubmitAccount).Click();
            return new MyAccountPageObject(chromeDriver);
        }
    }
}
