using OpenQA.Selenium;

namespace ta_task_1.PageObjects
{
    internal class SummerDressesPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _searchTopInput = By.XPath("//input[@id='search_query_top']");
        private readonly By _searchSubmitButton = By.XPath("//button[@name='submit_search']");

        public SummerDressesPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public SearchDressPageObject SelectionOfSummerDresses(string searchValue)
        {
            chromeDriver.FindElement(_searchTopInput).SendKeys(searchValue);

            chromeDriver.FindElement(_searchSubmitButton).Click();

            return new SearchDressPageObject(chromeDriver);
        }
    }
}
