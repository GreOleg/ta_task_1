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
            WaitUntil.ShouldLocate(chromeDriver, "http://automationpractice.com");
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(chromeDriver);
            mainMenu
                .SignIn()
                .LogIn(TestUserData.EmailUser)
                .RegistrationUser(
                TestUserData.FirstNameUser,
                TestUserData.LastNameUser,
                TestUserData.PasswordUser,
                TestUserData.DayBirthUser,
                TestUserData.MonthBirthUser,
                TestUserData.YearBirthUser,
                TestUserData.AddressUser,
                TestUserData.CityUser,
                TestUserData.StateUser,
                TestUserData.PostCodeUser,
                TestUserData.MobilePhoneUser)
                .ChoiceOfClothes()
                .SelectionOfSummerDresses(TestUserData.SearchKeyword)
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