using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ta_task_1.PageObjects
{
    internal class MyAccountPageObject
    {
        private IWebDriver chromeDriver;

        private readonly By _topMenuDressLink = By.XPath("//div[@id='block_top_menu']/ul/li[2]/a");
        private readonly By _popUpMenuSummerDresses = By.XPath("(//a[@title='Summer Dresses'][normalize-space()='Summer Dresses'])[2]");
        private readonly By _signOutButton = By.XPath("//a[@title='Log me out']");

        public MyAccountPageObject(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public SummerDressesPageObject ChoiceOfClothes()
        {
            new Actions(chromeDriver).MoveToElement(chromeDriver.FindElement(_topMenuDressLink)).Perform();

            WaitUntil.WaitElement(chromeDriver, _popUpMenuSummerDresses);
            chromeDriver.FindElement(_popUpMenuSummerDresses).Click();

            return new SummerDressesPageObject(chromeDriver);
        }

        public LogInMenuPageObject SignOut()
        {
            chromeDriver.FindElement(_signOutButton).Click();

            return new LogInMenuPageObject(chromeDriver);
        }
    }
}
