using NUnit.Framework;
using OpenQA.Selenium;

namespace ta_task_1
{
    public static class Asserts
    {
        public static void CheckElementDisplyed(IWebElement locator)
        {
            Assert.IsTrue(locator.Displayed);
        }
    }
}