using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ta_task_1.WrapperFactory
{
    class BrowserFactory
    {
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }
        public static void InitBrowser()
        {
            string browserName = Environment.GetEnvironmentVariable("BROWSER").ToUpper();

            if (browserName == "FIREFOX") { Driver = new FirefoxDriver(); return; }
            if (browserName == "CHROME") { Driver = new ChromeDriver(); return; }
            Driver = new ChromeDriver();
        }
        public static void PreconditionSetting()
        {   
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)Driver).ExecuteScript("document.body.style.zoom ='100%'");
        }
        public static void CloseAllDrivers()
        {
            Driver.Quit();
        }
    }
}