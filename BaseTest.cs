using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    public class BaseTest 
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [OneTimeSetUp]
        protected void DoBeforAllTheTests()
        {
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
        }

        [TearDown]
        protected void DoAfterEach()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [SetUp]
        protected void DoBeforEach()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(TestSettings.HostPrefix);

            WaitUntil.ShouldLocate(driver, TestSettings.LocationAutomationpractice);
        }
    }
}