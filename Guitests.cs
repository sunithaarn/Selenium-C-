using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQueryGUI
{
    class Guitests
    {

        IWebDriver chrome = new ChromeDriver();
        string url_datepicker = "https://jqueryui.com/datepicker/";
        
         Jguidatepicker jobj;
         
        [SetUp]
        public void Openurl()
        {

            chrome.Navigate().GoToUrl(url_datepicker);
            chrome.Manage().Window.Maximize();

        }


       [Test]
        public void Selectdate()
        {
            jobj = new Jguidatepicker(chrome);
                
           string result= jobj.Datepickerelement("15/12/2011");
            Assert.AreEqual("Success", result);
        }

       






    }
}
