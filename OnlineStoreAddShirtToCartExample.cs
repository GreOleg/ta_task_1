using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ta_task_1.Helpers;
using ta_task_1.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    [TestFixture(Description = "Add 'Faded Short Sleeve T-shirts' to cart")]
    [AllureNUnit]
    [NonParallelizable]
    public class OnlineStoreAddShirtToCartExample
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            BrowserFactory.InitBrowser();
            driver = BrowserFactory.Driver;
            driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AddShirtToCartExample()
        {
            //In the Search field, enter the value "shirts".
            WElement.Element(By.XPath("//input[@id='search_query_top']")).InputText("shirts");

            //Wait for the element under Search with the text "T-shirts > Faded Short Sleeve T-" to appear
            //and click on this element.
            WElement.Element(By.XPath("//li[contains(text(), 'T-shirts > Faded Short Sleeve T-')]")).EClick();

            //Wait for the product page to appear.
            WElement.Element(By.XPath("//body[@id='product']")).WaitElement();

            //Check that the product name is "Faded Short Sleeve T-shirts".
            string productTitle = driver.FindElement(By.XPath("//h1[contains(text(), 'Faded Short Sleeve T-shirts')]")).Text;
            Assert.AreEqual(productTitle, "Faded Short Sleeve T-shirts");

            //Click on the Add to cart button.
            WElement.Element(By.XPath("//p[@id='add_to_cart']/button")).EClick();

            //Wait for the element with the text "Product successfully added to your shopping cart".
            WElement.Element(By.XPath("//h2[normalize-space()='Product successfully added to your shopping cart']")).ExpectedConditionsElement();
            driver.FindElement(By.XPath("//h2[normalize-space()='Product successfully added to your shopping cart']")).Text.Equals("Product successfully added to your shopping cart");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}