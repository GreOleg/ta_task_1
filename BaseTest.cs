using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ta_task_1
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [OneTimeSetUp]
        protected void DoBeforAllTheTests()
        {
            _webDriver = new ChromeDriver();
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {

        }

        [TearDown]

        protected void DoAfterEach()
        {
            _webDriver.Quit();
        }

        [SetUp]
        protected void DoBeforEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.HostPrefix);
            _webDriver.Manage().Window.Maximize();

            WaitUntil.ShouldLocate(_webDriver, TestSettings.LocationAutomationpractice);
        }
    }
}
