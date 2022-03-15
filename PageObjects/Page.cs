using SeleniumExtras.PageObjects;
using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static MainPageObject MainPage
        {
            get => GetPage<MainPageObject>();
        }
        public static AuthenticationPageObject Authentication
        {
            get => GetPage<AuthenticationPageObject>();
        }
        public static RegistrationUserPageObject Registration
        {
            get => GetPage<RegistrationUserPageObject>();
        }
        public static MyAccountPageObject MyAccount
        {
            get => GetPage<MyAccountPageObject>();
        }
        public static SummerDressesPageObject SummerDressesPage
        {
            get => GetPage<SummerDressesPageObject>();
        }
        public static DressSearchResultPageObject DressSearchResultPage
        {
            get => GetPage<DressSearchResultPageObject>();
        }
        public static CartPageObject Cart
        {
            get => GetPage<CartPageObject>();
        }
    }
}
