using System;
using System.Threading;
using EditandDeleteTime.Pages;
using EditandDeleteTime.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EditandDeleteTime
{

    [TestFixture]

    [Parallelizable]

    class Employees_Tests : CommonDriver
    {


        [Test, Order(1)]


        public void CreateEMPTest()

        {

            // Employee page object initialization and definition

            HomePage homePageObj = new HomePage();
            homePageObj.Homepage2(driver);

            EmployeePage employeePageObj = new EmployeePage();

            employeePageObj.EmpolyeePageCreate(driver);


        }
        [Test, Order(2)]

        public void EditEmp()

        {
            HomePage homePageObj = new HomePage();
            homePageObj.Homepage2(driver);

            EmployeePage employeePageObj = new EmployeePage();

            employeePageObj.EmpolyeeEdit(driver);


    }
        [Test, Order(3)]

        public void DeleteEmp()

        {
            HomePage homePageObj = new HomePage();
            homePageObj.Homepage2(driver);

            EmployeePage employeePageObj = new EmployeePage();

            employeePageObj.DeleteTime(driver);


        }





    }
} 