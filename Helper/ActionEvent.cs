using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;


namespace ta_task_1.Helper
{
    class ActionEvent
    {
        public static void MoseOver(IWebDriver webDriver, By locator)
        {
            new Actions(webDriver).MoveToElement(webDriver.FindElement(locator)).Perform();
        }
    }
}
