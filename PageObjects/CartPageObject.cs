using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class CartPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _cartTitle = By.XPath("//h1[@id='cart_title']");
        private readonly By _chiffonDressInCart = By.XPath("//a[normalize-space()='Printed Chiffon Dress']");
        private readonly By _fadedSleeveInCart = By.XPath("//td[@class='cart_description']//a[contains(text(),'Faded Short Sleeve T-shirts')]");

        public CartPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public CartPageObject AssertItemsInCart()
        {
            WaitUntil.WaitElement(chromeDriver, _cartTitle);
            Asserts.CheckElementDisplyed(chromeDriver, _chiffonDressInCart);
            Asserts.CheckElementDisplyed(chromeDriver, _fadedSleeveInCart);
            return new CartPageObject(chromeDriver);
        }
    }
}
