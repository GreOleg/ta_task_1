using NUnit.Framework;
using ta_task_1.Helper;
using ta_task_1.PageObjects;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    [TestFixture]
    public class OnlineStoreTests
    {
        [Test]
        public void AddDressesToCartTest()
        {          
            BrowserFactory.InitBrowser(WebBrowsers.ChromeHeadlessMode);
            BrowserFactory.LoadApplication(TestSettings.HostPrefix);
            
            Page.MainPage.GoToAuthenticationPage();
            Page.Authentication.EnterUserEmail(Generaters.GenerateRandomEmail(TestUserData.domenForUserEmail));
            Page.Authentication.GoToRegistrationUserPage();
            Page.Registration.RegistrationUser(TestUserData.userData);
            Page.MyAccount.GoToSummerDressesPage();
            Page.SummerDressesPage.EnterKeyWordToSearcFiald(TestUserData.SearchKeyword);
            Page.DressSearchResultPage.AddChiffonDressToCart();
            Page.DressSearchResultPage.AddFadedSleeveShirtToCart();
            Page.DressSearchResultPage.GoToCart();
            Page.Cart.AssertChiffonDressInCart();
            Page.Cart.AssertFadedSleeveShirtInCart();

            BrowserFactory.CloseAllDrivers();
        }
    }
}