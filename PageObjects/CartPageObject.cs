using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ta_task_1.PageObjects
{
    internal class CartPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _cartTitle = By.XPath("//h1[@id='cart_title']");
        private readonly By _chiffonDressInCart = By.XPath("//a[normalize-space()='Printed Chiffon Dress']");
        private readonly By _fadedSleeveInCart = By.XPath("//td[@class='cart_description']//a[contains(text(),'Faded Short Sleeve T-shirts')]");

        public CartPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public CartPageObject CheckingItemsInCart()
        {
            var waitCartTitle = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10))
               .Until(drv => drv.FindElement(_cartTitle));

            IWebElement chiffonDressInCart = chromeDriver.FindElement(_chiffonDressInCart);
            Assert.IsTrue(chiffonDressInCart.Displayed);

            IWebElement fadedSleeveInCart = chromeDriver.FindElement(_fadedSleeveInCart);
            Assert.IsTrue(fadedSleeveInCart.Displayed);

            return new CartPageObject(chromeDriver);
        }
    }
}
