using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript
{
    [TestClass]
     public class DropDownlist
    {
        [TestMethod]
        public void TestList()
        {
            NavigationHelper.NavigationToUrl(ObjecRepository.Config.GetWebsite());
            HomePage hp = new HomePage();
            hp.SignInLink();
            hp.EnterUserDetials(ObjecRepository.Config.GetUsername(), ObjecRepository.Config.GetPassword());
            hp.SignInButton();
            IWebElement element = ObjecRepository.Driver.FindElement(By.LinkText("Women"));
            element.Click();
            IWebElement elementsort = ObjecRepository.Driver.FindElement(By.XPath("//select[@id='selectProductSort']"));
            SelectElement select = new SelectElement(elementsort);
           // select.DeselectByIndex(2);
            select.SelectByValue("name:asc");
            
            select.SelectByText("Reference: Lowest first");
            //will show the selected option - Lowest first
            Console.WriteLine("Selected value {0}",select.SelectedOption.Text);

            // will show all available options
            IList<IWebElement> list = select.Options;
            foreach (IWebElement ele in list)
            {
                Console.WriteLine("Value : {0},", ele.Text);
            }
        
        }
    }
}
