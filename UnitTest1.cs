using NUnit.Framework;
using ta_task_1.Helper;
using ta_task_1.PageObjects;
using ta_task_1.TestData;

namespace ta_task_1
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void Test_1()
        {              
            var mainPage = new MainPageObject(_webDriver);
            mainPage
                .GoToAuthenticationPage()
                .EnterUserEmail(Generaters.GenerateRandomEmail(TestUserData.domenForUserEmail))
                .RegistrationUser(TestUserData.userData)
                .GoToSummerDressesPage()
                .EnterKeyWordToSearcFiald(TestUserData.SearchKeyword)
                .AddDressesToCart()
                .AssertItemsInCart();          
        }
        [Test]
        public void Test_2()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.GoToAuthenticationPage();
            var authenticationPage = new AuthenticationPageObject(_webDriver);
            authenticationPage.EnterUserEmail(Generaters.GenerateRandomEmail(TestUserData.domenForUserEmail));
            var registrationUserPage = new RegistrationUserPageObject(_webDriver);
            registrationUserPage.RegistrationUser(TestUserData.userData);
            var myAccountPageObject = new MyAccountPageObject(_webDriver);
            myAccountPageObject.GoToSummerDressesPage();
            var summerDressesPageObject = new SummerDressesPageObject(_webDriver);
            summerDressesPageObject.EnterKeyWordToSearcFiald(TestUserData.SearchKeyword);
            var dressSearchResultsPageObject = new DressSearchResultPageObject(_webDriver);
            dressSearchResultsPageObject.AddDressesToCart();
            var cartPageObject = new CartPageObject(_webDriver);
            cartPageObject.AssertItemsInCart();
        }
        [Test]
        public void Test_3()
        {
            new MainPageObject(_webDriver).GoToAuthenticationPage();
            new AuthenticationPageObject(_webDriver).EnterUserEmail(Generaters.GenerateRandomEmail(TestUserData.domenForUserEmail));
            new RegistrationUserPageObject(_webDriver).RegistrationUser(TestUserData.userData);
            new MyAccountPageObject(_webDriver).GoToSummerDressesPage();
            new SummerDressesPageObject(_webDriver).EnterKeyWordToSearcFiald(TestUserData.SearchKeyword);
            new DressSearchResultPageObject(_webDriver).AddDressesToCart();
            new CartPageObject(_webDriver).AssertItemsInCart();
        }
    }
}