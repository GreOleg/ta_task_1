using OpenQA.Selenium;
using ta_task_1.Helper;

namespace ta_task_1.PageObjects
{
    class DressSearchResultPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _textUnderChiffonDressCard = By.CssSelector("h5[itemprop='name'] a[title='Printed Chiffon Dress']");
        private readonly By _addChiffonDressButton = By.XPath("//div[@class='button-container']//a[@data-id-product='7']/span[contains(text(),'Add to cart')]");
        private readonly By _continueShoppingButton = By.XPath("//span[@title='Continue shopping']//i");
        private readonly By _textUnderFadedSleeveCard = By.CssSelector("h5[itemprop='name'] a[title='Faded Short Sleeve T-shirts']");
        private readonly By _addFadedSleeveButton = By.XPath("//div[@class='button-container']//a[@data-id-product='1']/span[contains(text(),'Add to cart')]");
        private readonly By _proceedToCheckoutButton = By.XPath("//a[@title='Proceed to checkout']");

        public DressSearchResultPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public CartPageObject AddDressesToCart()
        {
            ActionEvent.MouseOver(chromeDriver, _textUnderChiffonDressCard);
            chromeDriver.FindElement(_addChiffonDressButton).Click();
            WaitUntil.ExpectedConditionsWaitElement(chromeDriver, _continueShoppingButton);
            chromeDriver.FindElement(_continueShoppingButton).Click();
            ActionEvent.MouseOver(chromeDriver, _textUnderFadedSleeveCard);
            chromeDriver.FindElement(_addFadedSleeveButton).Click();
            WaitUntil.ExpectedConditionsWaitElement(chromeDriver, _proceedToCheckoutButton);
            chromeDriver.FindElement(_proceedToCheckoutButton).Click();         
            return new CartPageObject(chromeDriver);
        }
    }
}
