using NUnit.Framework;
using System.Diagnostics;
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
        }

        [SetUp]
        protected void DoBeforEach()
        {
            BrowserFactory.PreconditionSetting();
            Trace.Flush();
        }
    }
}