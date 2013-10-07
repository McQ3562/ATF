using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ATF.ControlObjects
{
    class TextBoxControl : WebPageControl
    {
        IWebDriver webPageDriver;
        String controlName;

        public TextBoxControl(string ControlName, IWebDriver WebPageDriver)
        {
            controlName = ControlName;
            webPageDriver = WebPageDriver;
            
        }

        public void Write(string WriteString)
        {
            // Find the text input element by its name
            IWebElement query = webPageDriver.FindElement(By.Name(controlName));

            // Enter something to search for
            query.SendKeys(WriteString);
        }

        public string Read()
        {
            string readString = "";

            // Find the text input element by its name
            IWebElement query = webPageDriver.FindElement(By.Name(controlName));
            
            readString = query.Text;

            return readString;
        }

        public void Go(Action ActionObject)
        {

        }
    }
}
