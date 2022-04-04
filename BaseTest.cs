using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.IO;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    public class BaseTest
    {
        protected Person person;

        [OneTimeSetUp]
        protected void DoBeforAllTheTests()
        {
            BrowserFactory.InitBrowser();
            DataInitialization();
            Trace.Listeners.Add(new ConsoleTraceListener());
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
            //AllureLifecycle.Instance.CleanupResultDirectory();
        }

        public void DataInitialization()
        {
            new EnviromentConstantsProvider().Provide(out Person enviromentConstantsObject);
            person = enviromentConstantsObject;
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [TearDown]
        protected void DoAfterEach()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)BrowserFactory.Driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = @"C:\Users\ahresik\ta_task_1\" + filename;
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                TestContext.AddTestAttachment(path);
                AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
            }
        }

        [SetUp]
        protected void DoBeforEach()
        {
            BrowserFactory.PreconditionSetting();
            Trace.Flush();
        }
    }
}