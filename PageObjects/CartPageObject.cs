using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class CartPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.XPath, Using = "//h1[@id='cart_title']")]
        private IWebElement _cartTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Printed Chiffon Dress']")]
        private IWebElement _chiffonDressInCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@class='cart_description']//a[contains(text(),'Faded Short Sleeve T-shirts')]")]
        private IWebElement _fadedSleeveInCart { get; set; }

        private IWebElement _itemInCart;

        public void AssertChiffonDressInCart()
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _cartTitle);
            Asserts.CheckElementDisplyed(_chiffonDressInCart);
        }
        public void AssertFadedSleeveShirtInCart()
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _cartTitle);
            Asserts.CheckElementDisplyed(_fadedSleeveInCart);
        }

        public void AssertItemInCart(string item)
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _cartTitle);
            _itemInCart = BrowserFactory.Driver.FindElement(By.XPath($"//td[@class='cart_description']//a[contains(text(),'{item}')]"));
            Asserts.CheckText(_itemInCart, item);
        }
    }
}
