using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQueryGUI
{
    class Accordion
    {
        IWebDriver Adriver;
        public Accordion(IWebDriver driver)
        {
            Adriver = driver;
           // PageFactory.InitElements(Adriver, this);

        }


        
        public string Accordionaccess(int section)
        {

            Adriver.SwitchTo().Frame(Adriver.FindElement(By.XPath("//iframe[@class='demo-frame']")));
            if (section == 1) 
            {
                Adriver.FindElement(By.XPath("//h3[contains(.,'Section 1')]")).Click();
                return "Success";
            }
            else if(section==2)
            {

                Adriver.FindElement(By.XPath("//h3[contains(.,'Section 2')]")).Click();
                return "Success";
            }
            else if(section==3)
            {

                Adriver.FindElement(By.XPath("//h3[contains(.,'Section 3')]")).Click();
                IWebElement contentarea = Adriver.FindElement(By.Id("ui-id-6"));
                Console.Error.WriteLine(contentarea.Text);
                return "Success";
            }
            else if(section==4)
            {

                Adriver.FindElement(By.XPath("//h3[contains(.,'Section 4')]")).Click();
                return "Success";
            }
            else
            {
                return "Failure";

            }
        }

    }
}
