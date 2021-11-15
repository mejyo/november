using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EditandDeleteTime.Pages
{
    class EmployeePage
    {


        public void EmpolyeePageCreate(IWebDriver driver)

        {
            //click on create new button //*[@id="container"]/p/a
            IWebElement creatnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatnew.Click();
            Thread.Sleep(2000);

            // Enter the details of employees

            IWebElement EmpName = driver.FindElement(By.XPath("//*[@id='Name']"));
            EmpName.SendKeys("Maddy");

            Thread.Sleep(2000);

            IWebElement EmpUserName = driver.FindElement(By.XPath("//*[@id='Username']"));
            EmpUserName.SendKeys("Maddy");

            Thread.Sleep(2000);

            IWebElement EmpContact = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
            EmpContact.SendKeys("123456789");

            Thread.Sleep(2000);


            IWebElement EmpPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
            EmpPassword.SendKeys("Jyo@12345");

            Thread.Sleep(2000);

            IWebElement EmpRetypePassword = driver.FindElement(By.XPath("//*[@id='RetypePassword']"));
            EmpRetypePassword.SendKeys("Jyo@12345");

            Thread.Sleep(2000);

            IWebElement EmpAdmin = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));
            EmpAdmin.Click();
            Thread.Sleep(2000);

            IWebElement EmpVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            EmpVehicle.SendKeys("Benz");

            Thread.Sleep(2000);

            IWebElement EmpGruops = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]/input"));
            EmpGruops.SendKeys("group");
            Thread.Sleep(2000);




            IWebElement Savebutton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Savebutton.Click();
            Thread.Sleep(2000);

            IWebElement BacktoList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            BacktoList.Click();
            Thread.Sleep(2000);

            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2000);
            ////*[@id="usersGrid"]/div[3]/table/tbody/tr[4]/td[1]

            IWebElement actualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            IWebElement actualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(actualName.Text == "Maddy", "actual name and expected name dont match.");

            Assert.That(actualUsername.Text == "Maddy", "actual Typecode and expected Typecode dont match.");

        }



        public void EmpolyeeEdit(IWebDriver driver)

        {
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastpage.Click();

            Thread.Sleep(2000);

            Thread.Sleep(2000);

            IWebElement findRecordCreated1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated1.Text == "Maddy")
            {
                Thread.Sleep(5000);

                IWebElement Editnew = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                Editnew.Click();
                Thread.Sleep(2000);

                // Enter the details of employees

                IWebElement EditName = driver.FindElement(By.XPath("//*[@id='Name']"));
                EditName.Clear();
                EditName.SendKeys("sandy");

                Thread.Sleep(2000);

                IWebElement EditUserName = driver.FindElement(By.XPath("//*[@id='Username']"));
                EditUserName.Clear();
                EditUserName.SendKeys("sandy");

                Thread.Sleep(2000);

                IWebElement EditContact = driver.FindElement(By.XPath("//*[@id='ContactDisplay']"));
                EditContact.Clear();
                EditContact.SendKeys("1234567890");

                Thread.Sleep(2000);


                IWebElement EditPassword = driver.FindElement(By.XPath("//*[@id='Password']"));
                EditPassword.Clear();
                EditPassword.SendKeys("Jyo@123456");

                Thread.Sleep(2000);

                IWebElement EditRetypePassword = driver.FindElement(By.XPath("//*[@id='RetypePassword']"));
                EditRetypePassword.Clear();
                EditRetypePassword.SendKeys("Jyo@123456");

                Thread.Sleep(2000);

                IWebElement EmpAdmin = driver.FindElement(By.XPath("//*[@id='IsAdmin']"));

                EmpAdmin.Click();
                Thread.Sleep(2000);

                IWebElement EditVehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
                EditVehicle.Clear();
                EditVehicle.SendKeys("BMW");

                Thread.Sleep(2000);

                IWebElement EditGruops = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]/input"));
                EditGruops.Clear();
                EditGruops.SendKeys("group");
                Thread.Sleep(2000);




                IWebElement Savebutton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
                Savebutton.Click();
                Thread.Sleep(2000);

                IWebElement BacktoList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
                BacktoList.Click();
                Thread.Sleep(2000);

                IWebElement lastpage2 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
                lastpage2.Click();
                Thread.Sleep(2000);

                IWebElement EditedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

                IWebElement EditedUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

                Assert.That(EditedName.Text == "sandy", "actual name and expected name dont match.");

                Assert.That(EditedUsername.Text == "sandy", "actual Typecode and expected Typecode dont match.");

                Thread.Sleep(2000);
            }


            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }
        }



        public void DeleteTime(IWebDriver driver)

        {
            Thread.Sleep(2000);

            IWebElement lastpage1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastpage1.Click();
            Thread.Sleep(2000);

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "sandy")

            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();

                // Assert that Time record has been deleted.

                IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
                lastpage.Click();
                Thread.Sleep(2000);

                IWebElement EditedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

                IWebElement EditedUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

                Assert.That(EditedName.Text != "sandy", "actual name and expected name dont match.");

                Assert.That(EditedUsername.Text != "sandy", "actual Typecode and expected Typecode dont match.");

                Thread.Sleep(2000);

            }


            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }

        }

    }
}