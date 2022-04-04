using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;
using ta_task_1.TestData;
using ta_task_1.TestDataAccess;
using NUnit.Allure.Attributes;
using Allure.Commons;
using NUnit.Allure.Core;
using System;

namespace ta_task_1.PageObjects
{
    class RegistrationUserFormPageObject
    {
        protected Person person;
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

        //public void SubmitNewUserForm(Dictionary<string, string> user)
        //{
        //    WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountFormPersonalInformationForm);
        //    _createAnAccountFormPersonalInformationFirstName.SendKeys(user["firstNameUser"]);
        //    _createAnAccountFormPersonalInformationLastName.SendKeys(user["lastNameUser"]);
        //    _createAnAccountFormPersonalInformationPasswword.SendKeys(user["passwordUser"]);
        //    _createAnAccountFormYourAddressAddress.SendKeys(user["addressUser"]);
        //    _createAnAccountFormYourAddressCity.SendKeys(user["cityUser"]);
        //    new SelectElement(_createAnAccountFormYourAddressState).SelectByValue(user["stateUser"]);
        //    _createAnAccountFormYourAddressPostCode.SendKeys(user["postCodeUser"]);
        //    _createAnAccountFormYourAddressMobilePhone.SendKeys(user["mobilePhoneUser"]);
        //    _createAnAccountFormSubmitAccount.Click();
        //}

        //public void SubmitNewUserForm(Person person)
        //{
        //    WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountFormPersonalInformationForm);
        //    _createAnAccountFormPersonalInformationFirstName.SendKeys(person.firstNameUser);
        //    _createAnAccountFormPersonalInformationLastName.SendKeys(person.lastNameUser);
        //    _createAnAccountFormPersonalInformationPasswword.SendKeys(person.passwordUser);
        //    _createAnAccountFormYourAddressAddress.SendKeys(person.addressUser);
        //    _createAnAccountFormYourAddressCity.SendKeys(person.cityUser);
        //    new SelectElement(_createAnAccountFormYourAddressState).SelectByValue(person.stateUser);
        //    _createAnAccountFormYourAddressPostCode.SendKeys(person.postCodeUser);
        //    _createAnAccountFormYourAddressMobilePhone.SendKeys(person.mobilePhoneUser);
        //    _createAnAccountFormSubmitAccount.Click();
        //}
        //[AllureStep("Create new user with First Name #{0}, Last Name #{1}, Password #{2}, Addres #{3}, City #{4}, Mobile Phone #{7}")]
        //[AllureStep("Create new user with First Name {userData.firstNameUser}, Last Name {userData.lastNameUser}, Password {userData.passwordUser}, Addres {userData.addressUser}, City {userData.cityUser}, Mobile Phone {userData.mobilePhoneUser}")]
        [AllureStep]
        public void SubmitNewUserForm(string userId)
        {
            var userData = ExcelDataAccess.GetTestData(userId);

            WaitUntil.ExpectedConditionsWaitElement(driver, _createAnAccountFormPersonalInformationForm);
            _createAnAccountFormPersonalInformationFirstName.SendKeys(userData.firstNameUser);
            _createAnAccountFormPersonalInformationLastName.SendKeys(userData.lastNameUser);
            _createAnAccountFormPersonalInformationPasswword.SendKeys(userData.passwordUser);
            _createAnAccountFormYourAddressAddress.SendKeys(userData.addressUser);
            _createAnAccountFormYourAddressCity.SendKeys(userData.cityUser);
            new SelectElement(_createAnAccountFormYourAddressState).SelectByValue(userData.stateUser);
            _createAnAccountFormYourAddressPostCode.SendKeys(userData.postCodeUser);
            _createAnAccountFormYourAddressMobilePhone.SendKeys(userData.mobilePhoneUser);
            _createAnAccountFormSubmitAccount.Click();

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Console.WriteLine($"Create new user with First Name: {userData.firstNameUser}, Last Name: {userData.lastNameUser}, Password: {userData.passwordUser}, Addres: {userData.addressUser}, City: {userData.cityUser}, Mobile Phone: {userData.mobilePhoneUser}");
            }, "SubmitNewUserForm");
        }
    }
}
