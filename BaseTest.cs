using NUnit.Framework;
using System;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    public class BaseTest
    {
        //protected IWebDriver _webDriver;

        [OneTimeSetUp]
        protected void DoBeforAllTheTests()
        {
            BrowserFactory.InitBrowser();
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [TearDown]
        protected void DoAfterEach()
        {
            //_webDriver.Quit();
        }

        [SetUp]
        protected void DoBeforEach()
        {
            ////_webDriver = new ChromeDriver();
            //_webDriver.Manage().Cookies.DeleteAllCookies();
            //_webDriver.Navigate().GoToUrl(TestSettings.HostPrefix);
            //_webDriver.Manage().Window.Maximize();

            //WaitUntil.ShouldLocate(_webDriver, TestSettings.LocationAutomationpractice);
            BrowserFactory.LoadApplication(Environment.GetEnvironmentVariable("BASE_URL"));
        }
    }
}