using ta_task_1.WrapperFactory;

namespace ta_task_1.PageObjects
{
    class Navigation
    {
        public static void GoTo(string url)
        {
            BrowserFactory.Driver.Navigate().GoToUrl(url);
        }
    }
}
