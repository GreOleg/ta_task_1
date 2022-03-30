using NUnit.Allure.Core;
using NUnit.Framework;
using ta_task_1.PageObjects;

namespace ta_task_1
{
    [TestFixture]
    [AllureNUnit]
    [NonParallelizable]
    public class OnlineStoreCreateNewUserTest : BaseTest
    {
        [TestCase("User1")]
        [TestCase("User2")]
        [TestCase("User3")]
        [TestCase("User4")]
        [TestCase("User5")]
        public void CreateNewUserTest(string user)
        {
            Navigation.GoTo(Pages.MainPage);
            Page.MainPage.GoToAuthenticationPage();
            Page.CreateAnAccountForm.SubmitCreateAnAcountForm(Faker.Internet.Email());
            Page.Registration.SubmitNewUserForm(user);
        }
    }
}