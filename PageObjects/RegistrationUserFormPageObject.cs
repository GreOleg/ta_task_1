﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class RegistrationUserFormPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.CssSelector, Using = "form#account-creation_form")]
        private IWebElement _createAnAccountFormPersonalInformationForm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#customer_firstname")]
        private IWebElement _createAnAccountFormPersonalInformationFirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#customer_lastname")]
        private IWebElement _createAnAccountFormPersonalInformationLastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#passwd")]
        private IWebElement _createAnAccountFormPersonalInformationPasswword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#address1")]
        private IWebElement _createAnAccountFormYourAddressAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#city")]
        private IWebElement _createAnAccountFormYourAddressCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select#id_state")]
        private IWebElement _createAnAccountFormYourAddressState { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#postcode")]
        private IWebElement _createAnAccountFormYourAddressPostCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#phone_mobile")]
        private IWebElement _createAnAccountFormYourAddressMobilePhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button#submitAccount")]
        private IWebElement _createAnAccountFormSubmitAccount { get; set; }

        public void SubmitNewUserForm(Dictionary<string, string> user)
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountFormPersonalInformationForm);
            _createAnAccountFormPersonalInformationFirstName.SendKeys(user["firstNameUser"]);
            _createAnAccountFormPersonalInformationLastName.SendKeys(user["lastNameUser"]);
            _createAnAccountFormPersonalInformationPasswword.SendKeys(user["passwordUser"]);
            _createAnAccountFormYourAddressAddress.SendKeys(user["addressUser"]);
            _createAnAccountFormYourAddressCity.SendKeys(user["cityUser"]);
            new SelectElement(_createAnAccountFormYourAddressState).SelectByValue(user["stateUser"]);
            _createAnAccountFormYourAddressPostCode.SendKeys(user["postCodeUser"]);
            _createAnAccountFormYourAddressMobilePhone.SendKeys(user["mobilePhoneUser"]);
            _createAnAccountFormSubmitAccount.Click();
        }
    }
}