using NUnit.Framework;
using ta_task_1.PageObjects;

namespace ta_task_1
{
    [TestFixture]
    [NonParallelizable]
    public class OnlineStoreAddItemsToCartTest : BaseTest
    {
        [Test]
        public void AddItemsToCartTest()
        {
            Navigation.GoTo(Pages.MyAccountPage);
            Page.LogInForm.SubmitLogInForm("ivanov-3@example.com", "11111");
            Navigation.GoTo(Pages.SummerDressesPage);
            Page.SummerDressesPage.EnterKeyWordToSearcField("dress");
            Page.DressSearchResultPage.AddItemToCart("Printed Chiffon Dress", "7");
            Page.DressSearchResultPage.AddItemToCart("Faded Short Sleeve T-shirts", "1");
            Navigation.GoTo(Pages.CartPage);
            Page.Cart.AssertItemInCart("Printed Chiffon Dress");
            Page.Cart.AssertItemInCart("Faded Short Sleeve T-shirts");
        }
    }
}