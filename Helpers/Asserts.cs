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
        public static void CheckText(IWebElement locator, string expextedText)
        {
            Assert.AreEqual(expextedText, locator.Text);
        }
    }
}