using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using ta_task_1.Helper;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class MyAccountPageObject
    {
        private IWebDriver driver = BrowserFactory.Driver;

        [FindsBy(How = How.XPath, Using = "//div[@id='block_top_menu']/ul/li/a[@title='Dresses']")]
        private IWebElement _topMenuDressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@title='Summer Dresses'][normalize-space()='Summer Dresses'])[position()='2']")]
        private IWebElement _popUpMenuSummerDresses { get; set; }
        //public void GoToSummerDressesPage()
        //{
        //    ActionEvent.MouseOver(driver, _topMenuDressLink);
        //    WaitUntil.ExpectedConditionsWaitElement(driver, _popUpMenuSummerDresses);
        //    _popUpMenuSummerDresses.Click();
        //}
    }
}