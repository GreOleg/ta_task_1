using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.Helper;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class DressSearchResultPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.XPath, Using = "//span[@title='Continue shopping']//i")]
        private IWebElement _continueShoppingButton { get; set; }

        private By _textUnderItem;
        private By _addItem;

        public void AddItemToCart(string item, string idProdukt )
        {
            _textUnderItem = By.CssSelector($"h5[itemprop='name'] a[title='{item}']");
            _addItem = By.XPath($"//div[@class='button-container']//a[@data-id-product='{idProdukt}']/span[contains(text(),'Add to cart')]");
            ActionEvent.MouseOver(driver, _textUnderItem);
            BrowserFactory.Driver.FindElement(_addItem).Click();
            WaitUntil.ExpectedConditionsWaitElement(driver, _continueShoppingButton);
            _continueShoppingButton.Click();
        }
    }
}
