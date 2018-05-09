using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPOM
{
    class Loginpage
    {

        IWebDriver Logindriver;

        public Loginpage(IWebDriver Driver)
        {

           this.Logindriver = Driver;
            PageFactory.InitElements(Logindriver, this);


        }

        [FindsBy(How = How.Id, Using = ("UserName"))]
        IWebElement UsernameTxt { get; set; }

        [FindsBy(How =How.Id,Using =("Password"))]
        IWebElement PasswordTxt { get; set; }

        [FindsBy(How =How.XPath,Using =("//input[@value='Log in']"))]
        IWebElement LoginBtn { get; set; }


       public void EnterLogincredentials(String uname,String pwd)
        {
            UsernameTxt.SendKeys(uname);
            PasswordTxt.SendKeys(pwd);

        }

       public void ClickLogin()
        {
            LoginBtn.Click();
           // Logindriver.FindElement(By.i("1"));
        }



    }
}
