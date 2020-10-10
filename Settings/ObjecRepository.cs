using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Settings
{
    public class ObjecRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

    }
}
