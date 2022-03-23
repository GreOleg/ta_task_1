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
        private IWebElement _itemInCart;
        public void AssertItemInCart(string item)
        {
            WaitUntil.ExpectedConditionsWaitElement(driver, _cartTitle);
            _itemInCart = driver.FindElement(By.XPath($"//td[@class='cart_description']//a[contains(text(),'{item}')]"));
            Asserts.CheckText(_itemInCart, item);
        }
    }
}
