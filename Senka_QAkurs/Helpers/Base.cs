using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Configuration;

namespace Senka_QAkurs.Helpers
{
    [Binding]
    public class Base
    {
        public static IWebDriver Driver { get; private set; }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

            var url = ConfigurationManager.AppSettings["live"];
            Driver.Url = url;
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Quit();

        }

    }
}
