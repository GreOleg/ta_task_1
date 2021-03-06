using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using ta_task_1.Helpers;

namespace ta_task_1
{
    [TestFixture(Description = "Add 'Faded Short Sleeve T-shirts' to cart")]
    [AllureNUnit]
    [Parallelizable]
    //[NonParallelizable]
    public class OnlineStoreAddShirtToCart
    {
        private IWebDriver driver;

        private readonly By _searchInputButton = By.XPath("//input[@id='search_query_top']");
        private readonly By _actualResult = By.XPath("//li[contains(text(), 'T-shirts > Faded Short Sleeve T-')]");
        private readonly By _productPage = By.XPath("//body[@id='product']");
        private readonly By _productName = By.XPath("//h1[contains(text(), 'Faded Short Sleeve T-shirts')]");
        private readonly By _addCardButton = By.XPath("//p[@id='add_to_cart']/button");
        private readonly By _succesResultHeader = By.XPath("//h2[normalize-space()='Product successfully added to your shopping cart']");

        [SetUp]

        public void Setup()
        {
            var options = new ChromeOptions();
            options.BrowserVersion = "99";

            var runName = GetType().Assembly.GetName().Name;
            var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";
            var cloudOptions = new Dictionary<string, object>();

            cloudOptions.Add("name", runName);
            cloudOptions.Add("logName", $"{runName}.{timestamp}.log");
            cloudOptions.Add("videoName", $"{runName}.{timestamp}.mp4");
            cloudOptions.Add("enableVNC", true);
            cloudOptions.Add("enableLog", true);
            cloudOptions.Add("enableVideo", true);

            options.AddAdditionalOption("selenoid:options", cloudOptions);

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AddShirtToCart()
        {
            //In the Search field, enter the value "shirts".
            var searchField = driver.FindElement(_searchInputButton);
            searchField.SendKeys("shirts");

            //Wait for the element under Search with the text "T-shirts > Faded Short Sleeve T-" to appear
            //and click on this element.
            WrapperForElement.ElementClick(driver, _actualResult);

            //Wait for the product page to appear.
            WrapperForElement.WaitElement(driver, _productPage);

            //Check that the product name is "Faded Short Sleeve T-shirts".
            var productTitle = driver.FindElement(_productName);
            Assert.AreEqual(productTitle.Text, "Faded Short Sleeve T-shirts");

            //Click on the Add to cart button.
            WrapperForElement.ElementClick(driver, _addCardButton);

            //Wait for the element with the text "Product successfully added to your shopping cart".
            WrapperForElement.ExpectedConditionsWaitElement(driver, _succesResultHeader);
            driver.FindElement(_succesResultHeader).Text.Equals("Product successfully added to your shopping cart");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}