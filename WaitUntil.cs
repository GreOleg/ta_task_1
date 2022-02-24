﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;

namespace ta_task_1
{
    public static class WaitUntil
    {
        public static void ShouldLocate(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(e => e.Url.ToLowerInvariant().Contains(location.ToLowerInvariant()));
            }
            catch (WebDriverTimeoutException ex)
            {

                throw new NotFoundException($"Can not look for app in specific location: {location}", ex);
            }
        }

        public static void WaitSomeInterval(int seconds = 3)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(e => e.FindElement(locator));
        }
    }
}