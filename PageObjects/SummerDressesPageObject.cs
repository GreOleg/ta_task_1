using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class SummerDressesPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='search_query_top']")]
        private IWebElement _searchTopInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@name='submit_search']")]
        private IWebElement _searchSubmitButton { get; set; }
        public void EnterKeyWordToSearcFiald(string searchValue)
        {
            _searchTopInput.SendKeys(searchValue);
            _searchSubmitButton.Click();
        }
    }
}
