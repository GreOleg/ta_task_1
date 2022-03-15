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

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (driver == null)
                    {
                        Driver = new FirefoxDriver();
                    }
                    break;

                case "Chrome":
                    if (driver == null)
                    {
                        Driver = new ChromeDriver();
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            WaitUntil.ShouldLocate(driver, url);
        }

        public static void CloseAllDrivers()
        {
             Driver.Close();
             Driver.Quit();           
        }
    }
}