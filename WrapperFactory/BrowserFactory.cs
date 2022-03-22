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

        //public static void InitBrowser(WebBrowsers browserName)
        //{
        //    switch (browserName)
        //    {
        //        case WebBrowsers.Firefox:
        //            if (driver == null)
        //            {
        //                Driver = new FirefoxDriver();
        //            }
        //            break;

        //        case WebBrowsers.Chrome:
        //            //if (driver == null)
        //            //{   
        //            //    Driver = new ChromeDriver();
        //            //}
        //            Driver = new ChromeDriver();
        //            break;

        //        case WebBrowsers.CromeIncognitoMode:
        //            if (driver == null)
        //            {
        //                ChromeOptions chromeOptions = new ChromeOptions();
        //                chromeOptions.AddArgument("--incognito");
        //                Driver = new ChromeDriver(chromeOptions);
        //            }
        //            break;

        //        case WebBrowsers.ChromeHeadlessMode:
        //            if (driver == null)
        //            {
        //                ChromeOptions chromeOptions = new ChromeOptions();
        //                chromeOptions.AddArgument("--headless");
        //                Driver = new ChromeDriver(chromeOptions);
        //            }
        //            break;
        //    }
        //}
        //public static void InitBrowser(WebBrowsers browserName)
        //{
        //    if (browserName == WebBrowsers.Firefox) { Driver = new FirefoxDriver(); return; }
        //    if (browserName == WebBrowsers.Chrome) { Driver = new ChromeDriver(); return; }
        //    Driver = new ChromeDriver();
        //}

        public static void InitBrowser()
        {
            string browserName = Environment.GetEnvironmentVariable("BROWSER").ToUpper();

            if (browserName == "FIREFOX") { Driver = new FirefoxDriver(); return; }
            if (browserName == "CHROME") { Driver = new ChromeDriver(); return; }
            //Driver = new ChromeDriver();
        }
        public static void LoadApplication(string url)
        {   
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)Driver).ExecuteScript("document.body.style.zoom ='100%'");
            WaitUntil.ShouldLocate(driver, url);
        }

        public static void CloseAllDrivers()
        {
            Driver.Quit();
        }
    }
}