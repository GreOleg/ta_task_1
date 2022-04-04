using ta_task_1.WrapperFactory;
using NLog;
using NUnit.Allure.Attributes;

namespace ta_task_1.PageObjects
{
    class Navigation
    {   
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        [AllureStep("Go to URL => {0}")]
        public static void GoTo(string url)
        {
            BrowserFactory.Driver.Navigate().GoToUrl(url);
            _logger.Info($"Opend url => {url}");
        }
    }
}
