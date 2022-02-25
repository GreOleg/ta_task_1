using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    class SummerDressesPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _searchTopInput = By.XPath("//input[@id='search_query_top']");
        private readonly By _searchSubmitButton = By.XPath("//button[@name='submit_search']");

        public SummerDressesPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public DressSearchResultPageObject EnterKeyWordToSearcFiald(string searchValue)
        {
            chromeDriver.FindElement(_searchTopInput).SendKeys(searchValue);
            chromeDriver.FindElement(_searchSubmitButton).Click();
            return new DressSearchResultPageObject(chromeDriver);
        }
    }
}
