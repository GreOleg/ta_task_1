using NUnit.Framework;
using ta_task_1.Helper;
using ta_task_1.PageObjects;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    [TestFixture]
    [NonParallelizable]
    public class OnlineStoreCreateNewUserTest : BaseTest
    {
        [Test]
        public void CreateNewUserTest()
        {          
            //BrowserFactory.InitBrowser(WebBrowsers.Chrome);
            //BrowserFactory.LoadApplication(TestSettings.BaseUrl);
            
            Page.MainPage.GoToAuthenticationPage();
            Page.CreateAnAccountForm.SubmitCreateAnAcountForm(Generaters.GenerateRandomEmail(TestUserData.domenForUserEmail));
            Page.Registration.RegistrationNewUser(TestUserData.userData);

            //BrowserFactory.CloseAllDrivers();
        }
    }
}