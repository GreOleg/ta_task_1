using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
