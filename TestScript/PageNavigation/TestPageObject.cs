using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void Login()
        {

            NavigationHelper.NavigationToUrl(ObjecRepository.Config.GetWebsite());
            HomePage hp = new HomePage();
            hp.SignInLink();
            hp.EnterUserDetials(ObjecRepository.Config.GetUsername(), ObjecRepository.Config.GetPassword());
            hp.SignInButton();
            
            //hp.ConfirmUserLoggedIn();


        }
    }
}
