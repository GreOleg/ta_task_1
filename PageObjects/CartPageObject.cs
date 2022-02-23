using OpenQA.Selenium;

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
            WaitUntil.WaitElement(chromeDriver, _cartTitle);

            Checks.CheckElementDisplyed(chromeDriver, _chiffonDressInCart);

            Checks.CheckElementDisplyed(chromeDriver, _fadedSleeveInCart);

            return new CartPageObject(chromeDriver);
        }
    }
}
