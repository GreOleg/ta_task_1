using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ta_task_1.Helper
{
    class ActionEvent
    {
        public static void MouseOver(IWebDriver webDriver, By locator)
        {
            new Actions(webDriver).MoveToElement(webDriver.FindElement(locator)).Perform();
        }
    }
}
