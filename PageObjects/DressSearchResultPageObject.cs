using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ta_task_1.Helper;

namespace ta_task_1.PageObjects
{
    class DressSearchResultPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _textUnderChiffonDressCard = By.CssSelector("h5[itemprop='name'] a[title='Printed Chiffon Dress']");
        private readonly By _addChiffonDressButton = By.XPath("(//a[@title='Add to cart'])[4]");
        private readonly By _continueShoppingButton = By.XPath("//*[@id='layer_cart']/div[1]/div[1]/span");
        private readonly By _textUnderFadedSleeveCard = By.CssSelector("h5[itemprop='name'] a[title='Faded Short Sleeve T-shirts']");
        private readonly By _addFadedSleeveButton = By.XPath("(//a[@title='Add to cart'])[6]");
        private readonly By _proceedToCheckoutButton = By.XPath("//a[@title='Proceed to checkout']");

        public DressSearchResultPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public CartPageObject AddDressesToCart()
        {
            ActionEvent.MoseOver(chromeDriver, _textUnderChiffonDressCard);
            chromeDriver.FindElement(_addChiffonDressButton).Click();
            WaitUntil.ExpectedConditionsWaitElement(chromeDriver, _continueShoppingButton);
            chromeDriver.FindElement(_continueShoppingButton).Click();
            ActionEvent.MoseOver(chromeDriver, _textUnderFadedSleeveCard);
            chromeDriver.FindElement(_addFadedSleeveButton).Click();
            WaitUntil.ExpectedConditionsWaitElement(chromeDriver, _proceedToCheckoutButton);
            chromeDriver.FindElement(_proceedToCheckoutButton).Click();         
            return new CartPageObject(chromeDriver);
        }
    }
}
