using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.Helper;
using ta_task_1.Helpers;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class DressSearchResultPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.CssSelector, Using = "h5[itemprop='name'] a[title='Printed Chiffon Dress']")]
        private IWebElement _textUnderChiffonDressCard { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='button-container']//a[@data-id-product='7']/span[contains(text(),'Add to cart')]")]
        private IWebElement _addChiffonDressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@title='Continue shopping']//i")]
        private IWebElement _continueShoppingButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h5[itemprop='name'] a[title='Faded Short Sleeve T-shirts']")]
        private IWebElement _textUnderFadedSleeveCard { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='button-container']//a[@data-id-product='1']/span[contains(text(),'Add to cart')]")]
        private IWebElement _addFadedSleeveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='View my shopping cart']")]
        private IWebElement _cartButton { get; set; }

        public void AddChiffonDressToCart()
        {
            Scroll.ScrollDown(driver, 0.650);
            ActionEvent.MouseOver(driver, _textUnderChiffonDressCard);
            _addChiffonDressButton.Click();
            WaitUntil.ExpectedConditionsWaitElement(driver, _continueShoppingButton);
            _continueShoppingButton.Click();
        }
        public void AddFadedSleeveShirtToCart()
        {
            Scroll.ScrollDown(driver, 0.650);
            ActionEvent.MouseOver(driver, _textUnderFadedSleeveCard);
            _addFadedSleeveButton.Click();
            WaitUntil.ExpectedConditionsWaitElement(driver, _continueShoppingButton);
            _continueShoppingButton.Click();
        }
        public void GoToCart()
        {
            _cartButton.Click();
        }
    }
}
