using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
//using LumenWorks.Framework.IO.Csv;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TurnupPOM
{
    class LoginnunitTests
    {

        IWebDriver Chromebrowser;

        public  String Url = "http://horse-dev.azurewebsites.net";
        Loginpage LoginInstance;
        Dashboard dsh;
        Employees emp;
        Employeescreate createempobj;

        [OneTimeSetUp]

        public void OpenURl()
        {
            Chromebrowser = new ChromeDriver();
            Chromebrowser.Navigate().GoToUrl(Url);

            Chromebrowser.Manage().Window.Maximize();
                //String title = Chromebrowser.Title;
            //Console.WriteLine(title);
        }

        public void Loginfunctionality()
        {
            LoginInstance = new Loginpage(Chromebrowser);
            LoginInstance.EnterLogincredentials("ray", "123123");
            LoginInstance.ClickLogin();
         }

        [Test,Order(1)]

        public void TestLoginfunctionality()
         {

            Loginfunctionality();
            dsh = new Dashboard(Chromebrowser);
            String displayename = dsh.Userdisplay();
            Assert.AreEqual("Hello ray!", displayename);

        }
       [Test,Order(2)]
        public void SelectEmployees()
        {

            dsh = new Dashboard(Chromebrowser);
            dsh.ClickbtnAdministration();
            dsh.ClickEmployees();
            emp = new Employees(Chromebrowser);
            emp.Clickcreateuser();

            createempobj = new Employeescreate(Chromebrowser);
            createempobj.Employeescredentials();
            string resultuser = createempobj.ValidateData();
           Assert.AreEqual("Namefound", resultuser);
                                 
         }

       /* private static IEnumerable<string[]> TestData()
        {
            using (var csv = new CsvReader(new StreamReader("c:\\Users\\CC-MTR\\Desktop\\employee.csv"), true))
            {
                while (csv.ReadNextRecord())
                {
                    string name = csv[0];
                    int data2 = int.Parse(csv[1]);
                    int expectedOutput = int.Parse(csv[2]);
                    yield return new[] { data1, data2, expectedOutput };
                }
            }
        }*/

        /*  [OneTimeTearDown]
           public void CloseUrl()
           {
               Chromebrowser.Close();
           }*/

    }
}
