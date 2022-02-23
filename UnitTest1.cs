using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ta_task_1.PageObjects;

namespace ta_task_1
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver chromeDriver;
               
        private const string _emailUser = "ivanov-34@example.com";
        private const string _firstNameUser = "Ivan";
        private readonly string _lastNameUser = "Ivanov";
        private readonly string _passwordUser = "11111";
        private readonly string _dayBirthUser = "24";
        private readonly string _monthBirthUser = "9";
        private readonly string _yearBirthUser = "1993";
        private readonly string _addressUser = "123 Main Street East";
        private readonly string _cityUser = "Chicago";
        private readonly string _stateUser = "13";
        private readonly string _postCodeUser = "20521";
        private readonly string _mobilePhoneUser = "+375333333333";
        private readonly string _searchKeyword = "dress";

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
                .LogIn(_emailUser)
                .RegistrationUser(
                _firstNameUser,
                _lastNameUser,
                _passwordUser,
                _dayBirthUser,
                _monthBirthUser,
                _yearBirthUser,
                _addressUser,
                _cityUser,
                _stateUser,
                _postCodeUser,
                _mobilePhoneUser)
                .ChoiceOfClothes()
                .SelectionOfSummerDresses(_searchKeyword)
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