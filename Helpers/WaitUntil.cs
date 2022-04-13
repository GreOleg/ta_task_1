using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading.Tasks;

namespace ta_task_1
{
    public static class WaitUntil
    {
        public static void WaitSomeInterval(int seconds = 5)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void ExpectedConditionsWaitElement(IWebDriver webDriver, IWebElement locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        
    }
}
