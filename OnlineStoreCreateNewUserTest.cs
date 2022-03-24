using NUnit.Allure.Core;
using NUnit.Framework;
using ta_task_1.PageObjects;
using ta_task_1.TestData;

namespace ta_task_1
{
    [TestFixture]
    [AllureNUnit]
    [NonParallelizable]
    public class OnlineStoreCreateNewUserTest : BaseTest
    {
        [Test]
        public void CreateNewUserTest()
        {
            Navigation.GoTo(Pages.MainPage);
            Page.MainPage.GoToAuthenticationPage();
            Page.CreateAnAccountForm.SubmitCreateAnAcountForm(Faker.Internet.Email());
            Page.Registration.SubmitNewUserForm(person);
        }
    }
}