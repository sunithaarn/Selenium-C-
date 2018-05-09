using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JQueryGUI
{
    class Autocomplete
    {
        IWebDriver Autodriver;

        public Autocomplete(IWebDriver driver)
        {

            Autodriver = driver;
            PageFactory.InitElements(Autodriver, this);

        }

        [FindsBy(How =How.XPath,Using = "//input[@autocomplete='off']")]
        IWebElement Tag { get; set; }


        public void Autocompleteaccess(string option)
        {
            
            Autodriver.SwitchTo().Frame(Autodriver.FindElement(By.XPath(".//*[@id='content']/iframe")));
            Tag.SendKeys(option);
            Tag.SendKeys(Keys.Tab);
            
            
         }

    }
}
