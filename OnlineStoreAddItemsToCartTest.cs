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

            Page.MainPage.GoToAuthenticationPage();
            Page.LogInForm.SubmitLogInForm("ivanov-3@example.com", "11111");
            Page.MyAccount.GoToSummerDressesPage();
            Page.SummerDressesPage.EnterKeyWordToSearcFiald(TestUserData.SearchKeyword);
            Page.DressSearchResultPage.AddChiffonDressToCart();
            Page.DressSearchResultPage.AddFadedSleeveShirtToCart();
            Page.DressSearchResultPage.GoToCart();
            Page.Cart.AssertChiffonDressInCart();
            Page.Cart.AssertFadedSleeveShirtInCart();

            //BrowserFactory.CloseAllDrivers();
        }
    }
}