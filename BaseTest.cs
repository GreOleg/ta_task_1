using NUnit.Framework;
using System;
using ta_task_1.TestData;
using ta_task_1.WrapperFactory;

namespace ta_task_1
{
    public class BaseTest
    {
        [OneTimeSetUp]
        protected void DoBeforAllTheTests()
        {
            BrowserFactory.InitBrowser();
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [TearDown]
        protected void DoAfterEach()
        {
        }

        [SetUp]
        protected void DoBeforEach()
        {
            BrowserFactory.PreconditionSetting();
        }
    }
}