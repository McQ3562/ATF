using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ATF.ControlObjects
{
    class WebPageControl
    {
        IWebDriver webDriver;

        public void OpenFireFox()
        {
            webDriver = new FirefoxDriver();
        }

        public void Navigate(String DestinationURL)
        {
            webDriver.Navigate().GoToUrl(DestinationURL);
        }

        public void CLoseBrowser()
        {
            webDriver.Quit();
        }
    }
}
