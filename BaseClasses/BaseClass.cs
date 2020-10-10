using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomException;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
       

        [AssemblyInitialize]
        public static void InitWebdriver (TestContext tc)
        {
            ObjecRepository.Config = new AppConfigReader();

            switch (ObjecRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjecRepository.Driver = GetFirefoxDriver();
                     break;

                case BrowserType.Chrome:
                    ObjecRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjecRepository.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver Not found : "+ObjecRepository.Config.GetBrowser().ToString());
                    
            }
        //}
        //[AssemblyCleanup]
        //public static void TearDown()
        //{
        //    if (ObjecRepository.Driver != null)
        //    {
        //        ObjecRepository.Driver.Close();
        //        ObjecRepository.Driver.Quit();
        //    }

        }
    }
}
