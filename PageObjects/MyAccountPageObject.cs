using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ta_task_1.PageObjects
{
    internal class MyAccountPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _topMenuDressLink = By.XPath("//div[@id='block_top_menu']/ul/li[2]/a");
        private readonly By _popUpMenuSummerDresses = By.XPath("(//a[@title='Summer Dresses'][normalize-space()='Summer Dresses'])[2]");

        public MyAccountPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public SummerDressesPageObject ChoiceOfClothes()
        {
            Actions action1 = new Actions(chromeDriver);

            IWebElement topMenuDressLink = chromeDriver.FindElement(_topMenuDressLink);
            action1.MoveToElement(topMenuDressLink).Perform();

            WebDriverWait waitPopUpMenu = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10));
            IWebElement popUpMenuSummerDresses = waitPopUpMenu.Until(e => e.FindElement(_popUpMenuSummerDresses));
            popUpMenuSummerDresses.Click();

            return new SummerDressesPageObject(chromeDriver);
        }
    }
}
