using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigationToUrl(string Url)
        {
            ObjecRepository.Driver.Navigate().GoToUrl(Url);
            ObjecRepository.Driver.Manage().Window.Maximize();
        }
    }
}
