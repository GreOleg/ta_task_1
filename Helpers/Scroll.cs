using OpenQA.Selenium;

namespace ta_task_1.Helpers
{
    class Scroll
    {
        public static void ScrollDown(IWebDriver webDriver, double scrollParammetr)
        {
            ((IJavaScriptExecutor)webDriver).ExecuteScript($"scroll({scrollParammetr});");
        }
    }
}
