using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace ta_task_1.Helpers
{
    class WrapperForElement
    {
        public static void ElementClick(IWebDriver driver, By locator)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
                driver.FindElement(locator).Click();
                LogManager.GetCurrentClassLogger().Info($"Element identified by {locator.ToString}");
            }

            catch (StaleElementReferenceException sere)
            {
                // simply retry finding the element in the refreshed DOM
                driver.FindElement(locator).Click();
            }
            catch (TimeoutException toe)
            {
                LogManager.GetCurrentClassLogger().Error("Element identified by " + locator.ToString() + " was not clickable after 10 seconds");
            }
        }
        public static void WaitElement(IWebDriver driver, By locator)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
                LogManager.GetCurrentClassLogger().Info($"Element - {locator.ToString} is visible");
            }

            catch (StaleElementReferenceException sere)
            {
                // simply retry finding the element in the refreshed DOM
                driver.FindElement(locator).Click();
            }
            catch (TimeoutException toe)
            {
                LogManager.GetCurrentClassLogger().Error("Element identified by " + locator.ToString() + " was not visiblee after 10 seconds");
            }
        }
        public static void ExpectedConditionsWaitElement(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}