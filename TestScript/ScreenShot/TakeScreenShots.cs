using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigationToUrl(ObjecRepository.Config.GetWebsite());
            HomePage hp = new HomePage();
            // hp.SignInLink();
            hp.OurStoreLink();           

            Screenshot screen = ObjecRepository.Driver.TakeScreenshot();
            screen.SaveAsFile("Screen3.jpeg", ScreenshotImageFormat.Jpeg);

            /* file is saved as Screen.jpeg, to check the file - right click Selenium Webdriver - 
            open folder in file explorer
            C:\Users\Nadeem\source\repos\SeleniumWebdriver\SeleniumWebdriver\bin\Debug */
        }
    }
}
