using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ta_task_1.Helper
{
    class ActionEvent
    {
        public static void MouseOver(IWebDriver webDriver, IWebElement locator)
        {
            new Actions(webDriver).MoveToElement(locator).Perform();
        }
    }
}
