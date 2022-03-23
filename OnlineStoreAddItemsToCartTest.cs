using NUnit.Framework;
using ta_task_1.Helper;
using ta_task_1.PageObjects;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    [TestFixture]
    [NonParallelizable]
    public class OnlineStoreAddItemsToCartTest : BaseTest
    {
        [Test]
        public void AddItemsToCartTest()
        {
            //BrowserFactory.InitBrowser(WebBrowsers.Chrome);
            //BrowserFactory.LoadApplication(TestSettings.BaseUrl);
            Navigation.GoTo(Pages.MyAccountPage);

            //Page.MainPage.GoToAuthenticationPage();
            Page.LogInForm.SubmitLogInForm("ivanov-3@example.com", "11111");
            //Page.MyAccount.GoToSummerDressesPage();
            Navigation.GoTo(Pages.SummerDressesPage);
            Page.SummerDressesPage.EnterKeyWordToSearcField("dress");
            Page.DressSearchResultPage.AddItemToCart("Printed Chiffon Dress", "7");
            Page.DressSearchResultPage.AddItemToCart("Faded Short Sleeve T-shirts", "1");
            //Page.DressSearchResultPage.AddFadedSleeveShirtToCart();
            //Page.DressSearchResultPage.GoToCart();
            Navigation.GoTo(Pages.CartPage);
            Page.Cart.AssertItemInCart("Printed Chiffon Dress");
            Page.Cart.AssertItemInCart("Faded Short Sleeve T-shirts");

            //BrowserFactory.CloseAllDrivers();
        }
    }
}