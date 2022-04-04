using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using ta_task_1.PageObjects;

namespace ta_task_1
{
    [TestFixture (Description = "Add 2 dresses to cart")]
    [AllureNUnit]
    [NonParallelizable]
    public class OnlineStoreAddItemsToCartTest : BaseTest
    {
        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureFeature("Core")]
        [AllureLink("Online Store", "http://automationpractice.com")]
        public void AddItemsToCartTest()
        {
            Navigation.GoTo(Pages.MyAccountPage);
            Page.LogInForm.SubmitLogInForm(person.emailUser, person.passwordUser);
            Navigation.GoTo(Pages.SummerDressesPage);
            Page.SummerDressesPage.EnterKeyWordToSearcField("dress");
            Page.DressSearchResultPage.AddItemToCart("Printed Chiffon Dress", "7");
            Page.DressSearchResultPage.AddItemToCart("Faded Short Sleeve T-shirts", "1");
            Navigation.GoTo(Pages.CartPage);
            //Page.Cart.AssertItemInCart("Printed Chiffon Dress");
            Page.Cart.AssertItemInCart("Printed Chiffon");
            Page.Cart.AssertItemInCart("Faded Short Sleeve T-shirts");
        }
    }
}