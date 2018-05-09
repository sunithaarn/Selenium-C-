using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TurnupPOM
{
    class Employeescreate
    {
        IWebDriver edriver;
        public Employeescreate(IWebDriver driver)

        {
            edriver = driver;
            PageFactory.InitElements(edriver, this);

        }

        [FindsBy(How = How.XPath, Using = "//input[@id='Name']")]
        IWebElement Txtname { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Username']")]
        IWebElement Txtuname { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ContactDisplay']")]
        IWebElement TxtContact { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        IWebElement Txtpwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='RetypePassword']")]
        IWebElement Txtrepwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='SaveButton']")]
       IWebElement Btnsave { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='EditContactButton']")]
         IWebElement BtnEditcontact { get; set; }

         [FindsBy(How = How.XPath, Using = ".//*[@id='FirstName']")]
         IWebElement Txtfname { get; set; }

         [FindsBy(How = How.XPath, Using = ".//*[@id='LastName']")]
         IWebElement Txtlname { get; set; }

         [FindsBy(How = How.XPath, Using = ".//*[@id='Phone']")]
         IWebElement Txtphone { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='submitButton']")]
        IWebElement Btnsavcontact { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Back to List')]")]
        IWebElement Lnkback { get; set; }
        public object TimeUnit { get; private set; }

        internal void Employeescredentials()
        {

            Txtname.SendKeys("flintoff");
            Txtuname.SendKeys("ronaldo");
            BtnEditcontact.Click();
            Thread.Sleep(2000); ;
            //IWebElement Editframe =
                edriver.SwitchTo().Frame(edriver.FindElement(By.CssSelector("iframe[title='Edit Contact']")));  
            //edriver.SwitchTo().Frame(Editframe);
            Thread.Sleep(2000);
             Txtfname.SendKeys("two");
            Txtlname.SendKeys("two");
            Txtphone.SendKeys("90200120450");
            Btnsavcontact.Click();
            edriver.SwitchTo().DefaultContent();
             Txtpwd.SendKeys("Abcd-1234");
            Txtrepwd.SendKeys("Abcd-1234");


            //Thread.Sleep(8000);

            //   edriver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(8);


          //  edriver.Manage().Timeouts().ImplicitWait=(TimeSpan.FromSeconds(8));

           WebDriverWait wait = new WebDriverWait(edriver,timeout:TimeSpan.FromSeconds(8));
            // wait.Until(ExpectedConditions.ElementExists(By.Id("SaveButton")));
              try
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(Btnsave)).Click();
                }
                catch (TargetInvocationException ex)
                {
                    Console.WriteLine(ex.InnerException);
                }


                /* DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(edriver);
                  fluentWait.Timeout = TimeSpan.FromSeconds(10);
                  fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
                  fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                  IWebElement Btnsave = fluentWait.Until(x => x.FindElement(By.XPath("//input[@id='SaveButton']")));*/
                // var _driver = new FirefoxDriver();



                // IWebElement Btnsave;


                /* WebDriverWait wait = new WebDriverWait(edriver, TimeSpan.FromSeconds(20));

                 Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
                 {
                    IWebElement savebtn= Web.FindElement(By.XPath("//input[@id='SaveButton']"));
                     if (savebtn.Displayed)
                     {
                         savebtn.Click();
                         return true;
                     }

                     return false;
                 });
             wait.Until(waitForElement);*/





               // Btnsave.Click();

               
            

           

           Thread.Sleep(6000);

           
            Lnkback.Click();

        }

       internal string ValidateData()
        {
            Thread.Sleep(3000);
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        string name = edriver.FindElement(By.XPath(".//*[@id='usersGrid']/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;

                        string uname = edriver.FindElement(By.XPath(".//*[@id='usersGrid']/div[3]/table/tbody/tr["+i+"]/td[2]")).Text;

                        if (name == "green" &&  uname==" " )
                        {
                            return "Namefound";
                        }

                    }
                    edriver.FindElement(By.XPath(".//*[@id='usersGrid']/div[4]/a[3]/span")).Click();
                }
            }
            catch (Exception e)
            {
                return ("testfailed" + e);
            }

        }
    }

}