using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EditandDeleteTime.Pages
{
    class TMPage
    {


        public void TMPageCreate(IWebDriver driver)

        {
            //click on create new button
            IWebElement creatnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatnew.Click();

            //click on typecode dropdown
            // select time from dropdown

            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            typecode.Click();
            Thread.Sleep(2000);

            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();
            Thread.Sleep(2000);



            //identify code textbox and enter value//*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("NOVEMBER");
            Thread.Sleep(2000);

            //identify descripton textbox and enter value
            IWebElement descripton = driver.FindElement(By.Id("Description"));
            descripton.SendKeys("NOVEMBER");
            Thread.Sleep(2000);

            //identify price per unit textbox and enter value
            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.Click();
            Thread.Sleep(2000);

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

            IWebElement actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement actualTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));



            Assert.That(actualcode.Text == "NOVEMBER", "actual code and expected code dont match.");

            Assert.That(actualTypecode.Text == "T", "actual Typecode and expected Typecode dont match.");

            Assert.That(actualDescription.Text == "NOVEMBER", "actual Description and expected Description dont match.");

            Assert.That(actualPrice.Text == "$13.00", "actual Price and expected Price dont match.");


        }

        public void EditTime(IWebDriver driver)


        {
            Thread.Sleep(2000);

            IWebElement lastpage1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage1.Click();
            Thread.Sleep(2000);

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "NOVEMBER")
            {
                Thread.Sleep(5000);

                // Edit time and Material  //*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]

                IWebElement editTimeAndMaterial = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editTimeAndMaterial.Click();


                //To Edit the codeText box data first clear the previous data and enter the latest one


                IWebElement codebox = driver.FindElement(By.Id("Code"));
                codebox.Clear();
                codebox.SendKeys("EditTimenovember");
                Thread.Sleep(2000);



                IWebElement descripton1 = driver.FindElement(By.Id("Description"));
                descripton1.Clear();
                descripton1.SendKeys("EditTimenovember");
                Thread.Sleep(2000);

                IWebElement priceperunit1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                priceperunit1.Click();
                Thread.Sleep(2000);

                // First clear the Price Per unit textbox and enter the value


                IWebElement pricetextBox = driver.FindElement(By.Id("Price"));
                pricetextBox.Clear();
                Thread.Sleep(2000);

                IWebElement priceperunit11 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                priceperunit11.Click();
                Thread.Sleep(2000);

                pricetextBox.SendKeys("11");
                Thread.Sleep(2000);


                IWebElement savebutton1 = driver.FindElement(By.Id("SaveButton"));
                savebutton1.Click();
                Thread.Sleep(2000);


                IWebElement lastpage2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastpage2.Click();
                Thread.Sleep(2000);


              

                IWebElement editedcode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

                IWebElement editedTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

                IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

                IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));



                Assert.That(editedcode1.Text == "EditTimenovember", "actual code and expected code dont match.");

                Assert.That(editedTypecode.Text == "T", "actual Typecode and expected Typecode dont match.");

                Assert.That(editedDescription.Text == "EditTimenovember", "actual Description and expected Description dont match.");

                Assert.That(editedPrice.Text == "$11.00", "actual Price and expected Price dont match.");

                Thread.Sleep(2000);
            }
            
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }
        }

        public  void DeleteTime(IWebDriver driver)

        {
            Thread.Sleep(2000);

            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2000);

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "EditTimenovember")

            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();

                // Assert that Time record has been deleted.

                IWebElement lastpage1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                lastpage1.Click();
                Thread.Sleep(2000);


                IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                // Assertion
                Assert.That(editedCode.Text != "EditedOctober2021", "Code record hasn't been deleted.");
                Assert.That(editedDescription.Text != "EditedOctober2021", "Description record hasn't been deleted.");
                Assert.That(editedPrice.Text != "$170.00", "Price record hasn't been deleted.");
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }

        }
    }
}