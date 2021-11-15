using System;
using System.Threading;
using EditandDeleteTime.Utilities;
using OpenQA.Selenium;

namespace EditandDeleteTime.Pages
{
    public class HomePage : CommonDriver
    {


        public void HomePage1(IWebDriver driver)

        {

            //click on administration tab

            IWebElement administrationbuttonTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationbuttonTab.Click();

            wait.WaitTobeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

            //select time and material from dropdown

            IWebElement timeoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeoption.Click();
            Thread.Sleep(2000);
        }
            public void Homepage2(IWebDriver driver)


            {


                // click on admistration button and select employe from dropdown

                IWebElement administrationbuttonTab1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                 administrationbuttonTab1.Click();
                Thread.Sleep(2000);

                 wait.WaitTobeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);
        
                 //select time and material from dropdown

                 IWebElement employeoption = driver.FindElement(By.XPath("html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                 employeoption.Click();
                 Thread.Sleep(2000);

        }

        }
    
    }
