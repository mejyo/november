using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace timemat
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

            // select material enter data
            IWebElement material = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            material.Click();

       

            IWebElement codebox = driver.FindElement(By.Id("Code"));
            codebox.SendKeys("NOVEMBERMAT");

            IWebElement descripton = driver.FindElement(By.Id("Description"));
            descripton.SendKeys("NOVEMBERMAT");
            Thread.Sleep(2000);

            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.Click();
            Thread.Sleep(2000);


            IWebElement pricetextbox = driver.FindElement(By.Id("Price"));
            pricetextbox.SendKeys("77");
            Thread.Sleep(2000);

            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(2000);

            // Edit time and Material//

           
            //go to last page and check the time record has created
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2000);


            // Edit time and Material////*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]
            IWebElement editTimeAndMaterial = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            editTimeAndMaterial.Click();
            Thread.Sleep(2000);

            //To Edit the codeText box data first clear the previous data and enter the latest one


            IWebElement codebox1 = driver.FindElement(By.Id("Code"));
            codebox1.Clear();
            codebox1.SendKeys("Editnovember");

            Thread.Sleep(2000);

            IWebElement descripton1 = driver.FindElement(By.Id("Description"));
            descripton1.Clear();
            descripton1.SendKeys("Editnovember");
            Thread.Sleep(2000);

            IWebElement priceperunit1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit1.Click();
           
          // First clear the Price Per unit textbox and enter the value

          
            IWebElement pricetextBox = driver.FindElement(By.Id("Price"));
            pricetextBox.Clear();

            IWebElement priceperunit11 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit11.Click();
            Thread.Sleep(2000);
            pricetextBox.SendKeys("11");
            Thread.Sleep(2000);

            IWebElement savebutton1 = driver.FindElement(By.Id("SaveButton"));
            savebutton1.Click();
            Thread.Sleep(2000);

            IWebElement lastpage1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage1.Click();
            Thread.Sleep(2000);


            // Deeleting the edited data
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            deletebutton.Click();
            Thread.Sleep(2000);

           
            IAlert simpleAlert = driver.SwitchTo().Alert();
            String alertText = simpleAlert.Text;
            simpleAlert.Accept();
            Thread.Sleep(2000);





        }
    }
}
