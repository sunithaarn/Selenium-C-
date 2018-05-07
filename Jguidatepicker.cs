
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JQueryGUI
{
    public class Jguidatepicker
    {
        IWebDriver Jdriver;

        public Jguidatepicker(IWebDriver driver)
        {
            Jdriver = driver;
            PageFactory.InitElements(Jdriver, this);

        }


        [FindsBy(How = How.XPath,Using = "//input[@class='hasDatepicker']")]
        IWebElement Datepicker { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[@title='Prev']")]
        IWebElement Previous { get; set; }

        [FindsBy(How = How.XPath,Using = "//span[@class='ui-datepicker-month']")]
        IWebElement Monthtopick { get; set; }

        [FindsBy(How=How.XPath,Using = "//span[@class='ui-datepicker-year']")]
        IWebElement Yeartopick { get; set; }

        [FindsBy(How =How.XPath,Using = "//span[contains(.,'Next')]")]
        IWebElement Next { get; set; }



        public string Datepickerelement(string datetopick)
        {

             char delimiter = '/';
             string[] datevaluetopick = datetopick.Split(delimiter);
            // Console.Error.Write(datevalue[2]);

             DateTime today=DateTime.Today;

             string datecurrent = today.ToString("dd/MM/yyyy");


             string[] currentyear = datecurrent.Split(delimiter);

             //            Console.Error.Write(currentyear[2]);

            Jdriver.SwitchTo().Frame(Jdriver.FindElement(By.XPath("//iframe[@src='/resources/demos/datepicker/default.html']")));
            
               
            Thread.Sleep(5000);
            Datepicker.Click();

            int yeartopick = int.Parse(datevaluetopick[2]);
            int cyear = int.Parse(currentyear[2]);

            int monthtopick = int.Parse(datevaluetopick[1]);
            int cmonth = int.Parse(currentyear[1]);

            int datepick = int.Parse(datevaluetopick[0]);


            if (yeartopick == cyear)
            {
                if(monthtopick == cmonth)
                {
                    try
                    {
                        Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                        return "Success";
                    }
                    catch(Exception exp)
                    {
                        return (exp.ToString());
                    }
                }
                else
                {
                    if(monthtopick< cmonth)
                    {
                        int monthdifference = cmonth - monthtopick;
                        for(int j=1;j<=monthdifference;j++)
                        {
                            Previous.Click();

                        }
                        try
                        {

                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }
                    else
                    {

                        int monthdifference = monthtopick - cmonth;
                        for(int j=1;j<=monthdifference;j++)
                        {

                            Next.Click();
                            
                        }
                        try
                        {
                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }

                }

            }

            else
            {
                int monthdifference;
                int monthcal;
                if (yeartopick < cyear)
                {
                    
                    int yeardifference = cyear - yeartopick;

                    if (monthtopick < cmonth)
                    {
                        monthdifference = cmonth - monthtopick;
                        monthcal = (yeardifference * 12) + monthdifference;
                        for (int k = 1; k <= monthcal; k++)
                        {
                            Previous.Click();

                        }
                        try
                        {

                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }
                    else
                    {

                        monthdifference = monthtopick - cmonth;
                        monthcal = (yeardifference * 12) - monthdifference;
                        for (int k = 1; k <= monthcal; k++)
                        {
                            Previous.Click();

                        }
                        try
                        {
                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }
                                 
                                      
                }

                else
                {

                    int yeardifference = yeartopick - cyear;

                    if (monthtopick < cmonth)
                    {
                        monthdifference = cmonth - monthtopick;
                        monthcal = (yeardifference * 12) - monthdifference;
                        for (int k = 1; k <= monthcal; k++)
                        {
                            Next.Click();

                        }
                        try
                        {

                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }
                    else
                    {

                        monthdifference = monthtopick - cmonth;
                        monthcal = (yeardifference * 12) + monthdifference;
                        for (int k = 1; k <= monthcal; k++)
                        {
                            Next.Click();

                        }
                        try
                        {
                            Jdriver.FindElement(By.XPath("//a[contains(.,'" + datepick + "')]")).Click();
                            return "Success";
                        }
                        catch (Exception exp)
                        {
                            return (exp.ToString());
                        }
                    }
                }


            }
         }
        
    }
}
