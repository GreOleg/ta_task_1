using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ta_task_1.PageObjects;
using ta_task_1.TestData;

namespace ta_task_1
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver chromeDriver;
               
        [SetUp]
        public void Setup()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("http://automationpractice.com");
            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(chromeDriver);
            mainMenu
                .SignIn()
                .LogIn(TestUserData.emailUser)
                .RegistrationUser(
                TestUserData.firstNameUser,
                TestUserData.lastNameUser,
                TestUserData.passwordUser,
                TestUserData.dayBirthUser,
                TestUserData.monthBirthUser,
                TestUserData.yearBirthUser,
                TestUserData.addressUser,
                TestUserData.cityUser,
                TestUserData.stateUser,
                TestUserData.postCodeUser,
                TestUserData.mobilePhoneUser)
                .ChoiceOfClothes()
                .SelectionOfSummerDresses(TestUserData.searchKeyword)
                .AddDressesToCart()
                .CheckingItemsInCart();          
        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Quit();
        }
    }
}