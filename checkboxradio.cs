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



        [FindsBy(How = How.XPath, Using = "html/body/div[1]/fieldset[1]")]
        IWebElement Radioelements { get; set; }


        [FindsBy(How = How.XPath, Using = "html/body/div[1]/fieldset[2]")]
        IWebElement Checkboxelements { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(.,' New York')]")]
        IWebElement Newyork { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(.,' Paris')]")]
        IWebElement Paris { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(.,' London')]")]
        IWebElement London { get; set; }


        public string Radioaccess(string option)
        {

            cdriver.SwitchTo().Frame(cdriver.FindElement(By.XPath("//iframe[@class='demo-frame']")));
            //cdriver.SwitchTo().Frame(Radioelements);
            if (option == "New York")
            {
                Newyork.Click();
                return "Success";

            }
            else if (option == "Paris")
            {
                Paris.Click();
                return "Success";
            }
            else if (option == "London")
            {
                London.Click();
                return "Success";
            }
            return "Fail";

        }

        public string Checkboxaccess(string v1, string v2, string v3, string v4)
        {

            string rating2 = "2 Star", rating3 = "3 Star",rating4= "4 Star",rating5= "5 Star";

           cdriver.SwitchTo().Frame(cdriver.FindElement(By.XPath("//iframe[@class='demo-frame']")));

            if ((v1 == rating2 || v1 == rating3 || v1 == rating4 || v1 == rating5) || (v2 == rating2 ||v2 == rating3 || v2 == rating4 || v2 == rating5) || (v3 == rating2 || v3 == rating3 || v3 == rating4 || v3 == rating5) || (v4 == rating2 ||v4 == rating3 || v4 == rating4 || v4 == rating5))
            {

                if ((v1 == rating2) || (v2 == rating2) || (v3 == rating2) || (v4 == rating2))
                {

                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[1]")).Click();

                }
                if ((v1 == rating3) || (v2 == rating3) || (v3 == rating3) || (v4 == rating3))
                {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[2]")).Click();

                }
                if ((v1 == rating4) || (v2 == rating4) || (v3 == rating4) || (v4 == rating4))
                {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[3]")).Click();

                }
                if ((v1 == rating5) || (v2 == rating5) || (v3 == rating5) || (v4 == rating5))
                {
                    cdriver.FindElement(By.XPath("html/body/div[1]/fieldset[2]/label[4]")).Click();
                    Thread.Sleep(5000);

                }

                return "Success";
            }
            else
            {
                return "Options not available";
            }


        }   


    }
}
