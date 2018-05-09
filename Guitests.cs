using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JQueryGUI
{
    class Guitests
    {

        IWebDriver chrome = new ChromeDriver();
        //string url_datepicker = "https://jqueryui.com/datepicker/";
        // string url_accordion = "https://jqueryui.com/accordion/";
          string url_autocomplete = "https://jqueryui.com/autocomplete/";

        // string url_checkboxradio = "https://jqueryui.com/checkboxradio/";

        /* Jguidatepicker jobj;
         Accordion Aobj;

         checkboxradio Cobj;*/
        Autocomplete aobj;
       

        [SetUp]
        public void Openurl()
        {

            // chrome.Navigate().GoToUrl(url_datepicker);
            //chrome.Navigate().GoToUrl(url_accordion);
            // chrome.Navigate().GoToUrl(url_checkboxradio);
            chrome.Navigate().GoToUrl(url_autocomplete);
             chrome.Manage().Window.Maximize();

        }


       /* [Test]
        public void Selectdate()
        {
            jobj = new Jguidatepicker(chrome);
                
           string result= jobj.Datepickerelement("15/12/2011");
            Assert.AreEqual("Success", result);
        }

        [Test]

        public void SelectAccordionSection()
        {
            Aobj = new Accordion(chrome);
           string result= Aobj.Accordionaccess(4);
            Assert.AreEqual("Success", result);

        }*/
        [Test]
        public void Autocompletesuccess()
        {

            aobj = new Autocomplete(chrome);
            aobj.Autocompleteaccess("Basic");
           
        }


        /*[Test]
        public void Selectradiooptions()
        {

            Cobj = new checkboxradio(chrome);
            string result = Cobj.Radioaccess("Paris");
            string result2 = Cobj.Checkboxaccess("2 Star");
            string result3 = Cobj.Checkboxaccess("4 Star");
        }*/
       /*[TestCase ("2 Star","3 Star","Null ","Null")]
       
       [TestCase ("Null","3 Star","Null","5 Star")]

        [TestCase ("Null","aaa","aaaa","aaaaa")]

        public void Selectcheckboxoptions(string v1,string v2,string v3,string v4)
        {
            Cobj = new checkboxradio(chrome);
           string result = Cobj.Checkboxaccess(v1,v2,v3,v4);
            Assert.AreEqual("Success", result);

        }*/

      
    }
}
