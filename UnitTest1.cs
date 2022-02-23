using NUnit.Framework;
using ta_task_1.PageObjects;
using ta_task_1.TestData;

namespace ta_task_1
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                .SignIn()
                .Registration(TestUserData.EmailUser)
                .RegistrationUser(
                TestUserData.FirstNameUser,
                TestUserData.LastNameUser,
                TestUserData.PasswordUser,
                TestUserData.DayBirthUser,
                TestUserData.MonthBirthUser,
                TestUserData.YearBirthUser,
                TestUserData.AddressUser,
                TestUserData.CityUser,
                TestUserData.StateUser,
                TestUserData.PostCodeUser,
                TestUserData.MobilePhoneUser)
                .SignOut()
                .LogIn(TestUserData.EmailUser, TestUserData.PasswordUser)
                .ChoiceOfClothes()
                .SelectionOfSummerDresses(TestUserData.SearchKeyword)
                .AddDressesToCart()
                .CheckingItemsInCart();          
        }
    }
}