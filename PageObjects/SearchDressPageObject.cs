using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace ta_task_1.PageObjects
{
    internal class SearchDressPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _centerColumn = By.XPath("//h1[1]");
        private readonly By _textUnderChiffonDressCard = By.CssSelector("h5[itemprop='name'] a[title='Printed Chiffon Dress']");
        private readonly By _addChiffonDressButton = By.XPath("(//a[@title='Add to cart'])[4]");
        private readonly By _productSuccessfullAddTitle = By.XPath("//h2[normalize-space()='Product successfully added to your shopping cart']");
        private readonly By _continueShoppingButton = By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span");
        private readonly By _textUnderFadedSleeveCard = By.CssSelector("h5[itemprop='name'] a[title='Faded Short Sleeve T-shirts']");
        private readonly By _addFadedSleeveButton = By.XPath("(//a[@title='Add to cart'])[6]");
        private readonly By _proceedToCheckoutButton = By.XPath("//a[@title='Proceed to checkout']");

        public SearchDressPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public CartPageObject AddDressesToCart()
        {
            var waitCenterColumn = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(20))
                .Until(drv => drv.FindElement(_centerColumn));

            Actions action2 = new Actions(chromeDriver);

            IWebElement chiffonDressCard = chromeDriver.FindElement(_textUnderChiffonDressCard);
            action2.MoveToElement(chiffonDressCard).Perform();

            chromeDriver.FindElement(_addChiffonDressButton).Click();

            Thread.Sleep(3000);

            WebDriverWait waitProductSuccessfullAddTitle = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(5));
            IWebElement productSuccessfullAddTitle = waitProductSuccessfullAddTitle.Until(e => e.FindElement(_productSuccessfullAddTitle));

            var continueShoppingButton = chromeDriver.FindElement(_continueShoppingButton);
            continueShoppingButton.Click();

            Actions action3 = new Actions(chromeDriver);

            IWebElement fadedSleeveCard = chromeDriver.FindElement(_textUnderFadedSleeveCard);
            action3.MoveToElement(fadedSleeveCard).Perform();

            IWebElement addFadedSleeveButton = chromeDriver.FindElement(_addFadedSleeveButton);
            addFadedSleeveButton.Click();

            Thread.Sleep(3000);

            WebDriverWait waitProceedToCheckoutButton = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10));
            IWebElement proceedToCheckoutButton = waitProceedToCheckoutButton.Until(e => e.FindElement(_proceedToCheckoutButton));
            proceedToCheckoutButton.Click();

            return new CartPageObject(chromeDriver);
        }
    }
}
