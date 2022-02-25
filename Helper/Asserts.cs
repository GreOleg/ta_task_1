using NUnit.Framework;
using OpenQA.Selenium;

namespace ta_task_1
{
    public static class Asserts
    {
        public static void CheckElementDisplyed(IWebDriver webDriver, By locator)
        {
            Assert.IsTrue(webDriver.FindElement(locator).Displayed);
        }
    }
}