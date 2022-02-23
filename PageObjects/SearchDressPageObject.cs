using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ta_task_1.PageObjects
{
    internal class SearchDressPageObject
    {
        private IWebDriver chromeDriver;

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

            new Actions(chromeDriver).MoveToElement(chromeDriver.FindElement(_textUnderChiffonDressCard)).Perform();

            chromeDriver.FindElement(_addChiffonDressButton).Click();

            WaitUntil.WaitSomeInterval();

            WaitUntil.WaitElement(chromeDriver, _productSuccessfullAddTitle);

            chromeDriver.FindElement(_continueShoppingButton).Click();

            new Actions(chromeDriver).MoveToElement(chromeDriver.FindElement(_textUnderFadedSleeveCard)).Perform();

            chromeDriver.FindElement(_addFadedSleeveButton).Click();

            WaitUntil.WaitSomeInterval();

            WaitUntil.WaitElement(chromeDriver, _proceedToCheckoutButton);
            chromeDriver.FindElement(_proceedToCheckoutButton).Click();
           
            return new CartPageObject(chromeDriver);
        }
    }
}
