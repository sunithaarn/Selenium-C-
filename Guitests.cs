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
    public class Guitests
    {

        IWebDriver chrome = new ChromeDriver();
        string Url = "https://jqueryui.com/demos/";

        Jguidatepicker jobj;
        Accordion Aobj;
        checkboxradio Cobj;
        Autocomplete aobj;
        demos demoobj;
       


        [SetUp]
        public void Openurl()
        {

            chrome.Navigate().GoToUrl(Url);
            chrome.Manage().Window.Maximize();

        }


        [TestCase("15/12/2011")]
        [TestCase("01/07/2018")]
        public void Selectdate(string date)
        {

            demoobj = new demos(chrome);
            demoobj.ClickDatepicker();
            jobj = new Jguidatepicker(chrome);
            string result = jobj.Datepickerelement(date);
            Assert.AreEqual("Success", result);
        }

        [TestCase(1)]
        [TestCase(3)]

        public void SelectAccordionSection(int section)
        {

            demoobj = new demos(chrome);
            demoobj.ClickAccordion();
            Aobj = new Accordion(chrome);
            string result = Aobj.Accordionaccess(section);
            Assert.AreEqual("Success", result);

        }

        [TestCase("Basic")]
        [TestCase("ActionScript")]
        public void Autocompletesuccess(string option)
        {
            demoobj = new demos(chrome);
            demoobj.ClickAutocomplete();
            aobj = new Autocomplete(chrome);
            aobj.Autocompleteaccess(option);

        }


        [TestCase("New York")]
        [TestCase("Paris")]
        [TestCase("London")]
        public void Selectradiooptions(string city)
        {
            demoobj = new demos(chrome);
            demoobj.ClickCheckradiobox();
            Cobj = new checkboxradio(chrome);
            string result = Cobj.Radioaccess(city);
        }


        const string Rating2 = "2 Star";
        const string Rating3 = "3 Star";
        const string Rating4 = "4 Star";
        const string Rating5 = "5 Star";
        const string NoRating = "Null";

        [TestCase(Rating5, Rating3, "null", "null")]

        [TestCase("null", "null",Rating2,"2222")]

        [TestCase("dddd", "dddddd", "ssss","ssss")]
        [TestCase(Rating5,Rating4,Rating2,Rating3)]


        public void Selectcheckboxoptions(string v1, string v2, string v3, string v4)
        {
            demoobj = new demos(chrome);
            demoobj.ClickCheckradiobox();
            Cobj = new checkboxradio(chrome);
            string result = Cobj.Checkboxaccess(v1, v2, v3, v4);
            if (result == "Success")
            {
                Assert.AreEqual("Success", result);
            }
            else
            {
                Assert.AreEqual("Options not available", result);
            }

        }



        [TearDown]
        public void CloseBrowser()
        {
            chrome.Close();
        }
    }
}
