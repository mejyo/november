
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TurnupPortalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and correct username
            IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
            usernametextbox.SendKeys("hari");

            //identify password textbox and correct password
            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");

            //IDENTIFY LOGIN AND CLICK
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

            // Check login happened successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Successfully,Test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }


            //click on administration tab
            IWebElement administrationbuttonTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationbuttonTab.Click();

            //select time and material from dropdown
            IWebElement timeoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeoption.Click();
            Thread.Sleep(2000);

            //click on create new button
            IWebElement creatnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatnew.Click();

            //click on typecode dropdown
            // select time from dropdown
            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));

            IWebElement time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
        

            //identify code textbox and enter value
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("NOVEMBER");
            Thread.Sleep(2000);

            //identify descripton textbox and enter value
            IWebElement descripton = driver.FindElement(By.Id("Description"));
            descripton.SendKeys("NOVEMBER");

            //identify price per unit textbox and enter value
            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.Click();

            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.SendKeys("13");

            //click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(2000);


            //go to last page and check the time record has created
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2000);


            IWebElement actualcode = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/table/tbody/tr[9]/td[1]"));
         

            if (actualcode.Text == "NOVEMBER")
            {
                Console.WriteLine("Time record created successfully.");
            }
            
                else
            { 
                    Console.WriteLine("Test failed");


            }



        }




    }
}

