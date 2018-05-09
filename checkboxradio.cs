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
    class checkboxradio
    {
        IWebDriver cdriver;
        public checkboxradio(IWebDriver driver)
        {
            cdriver = driver;
            PageFactory.InitElements(cdriver, this);

        }

        

        [FindsBy(How =How.XPath,Using = "html/body/div[1]/fieldset[1]")]
        IWebElement Radioelements { get; set; }


        [FindsBy(How =How.XPath,Using = "html/body/div[1]/fieldset[2]")]
        IWebElement Checkboxelements { get; set; }

        [FindsBy(How =How.XPath,Using = "//label[contains(.,' New York')]")]
        IWebElement Newyork { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(.,' Paris')]")]
        IWebElement Paris { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(.,' London')]")]
        IWebElement London { get; set; }

        
        public string Radioaccess(string option)
        {

            cdriver.SwitchTo().Frame(cdriver.FindElement(By.XPath("//iframe[@class='demo-frame']")));
            //cdriver.SwitchTo().Frame(Radioelements);
            if(option=="New York")
            {
                Newyork.Click();
                return "Success";

            }
            else if(option=="Paris")
            {
                Paris.Click();
                return "Success";
            }
            else if(option =="London")
            {
                London.Click();
                return "Success";
            }
            return "Fail";

        }

        public string Checkboxaccess(string v1,string v2,string v3,string v4)
        {


            cdriver.SwitchTo().Frame(cdriver.FindElement(By.XPath("//iframe[@class='demo-frame']")));
            if ((v1 == "2 Star") || (v2 == "2 Star") || (v3 == "2 Star") || (v4 == "2 Star")) 
                {
                
                cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[1]")).Click();
                   
                }
                if ((v1 == "3 Star") || (v2 == "3 Star") || (v3 == "3 Star") || (v4 == "3 Star"))
                    {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[2]")).Click();
                   
                }
                if((v1 == "4 Star") || (v2 == "4 Star") || (v3 == "4 Star") || (v4 == "4 Star"))
                {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[3]")).Click();
                    
                }
                if ((v1 == "5 Star") || (v2 == "5 Star") || (v3 == "5 Star") || (v4 == "5 Star"))
                {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[4]")).Click();
                Thread.Sleep(5000);
                return "Success";
                }
           
            return "Options not available";
            
        }
        

   }
}
