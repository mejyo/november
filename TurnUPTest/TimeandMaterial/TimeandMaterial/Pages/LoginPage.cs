using System;
using System.Threading;
using EditandDeleteTime.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EditandDeleteTime.Pages
    {
        public class LoginPage : CommonDriver
        {

        public void LoginAction(IWebDriver driver)

            {
           
                // launch turnup portal

                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

                driver.Manage().Window.Maximize();

          
                //identify username textbox and correct username

                IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
                usernametextbox.SendKeys("hari");

                wait.WaitTobeVisible(driver, "Id", "Password", 2);

                //identify password textbox and correct password

                IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
                passwordtextbox.SendKeys("123123");

                //IDENTIFY LOGIN AND CLICK

                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

            



        }


    }

        }
    
        
    
