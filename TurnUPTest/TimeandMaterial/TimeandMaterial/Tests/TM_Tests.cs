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

    class TM_Tests : CommonDriver
    {

        [Test, Order(1)]

        public void CreateTMTest()

        {
            HomePage homePageObj = new HomePage();
            homePageObj.HomePage1(driver);

            TMPage tmPageObj = new TMPage();

            tmPageObj.TMPageCreate(driver);

        }

          [Test, Order(2)]

        public void EditTMTest()

       {

            HomePage homePageObj = new HomePage();
            homePageObj.HomePage1(driver);

            TMPage tmPageObj = new TMPage();

            tmPageObj.EditTime(driver);

       }


           [Test, Order(3)]

        public void DeleteTMTest()

         {

            HomePage homePageObj = new HomePage();
            homePageObj.HomePage1(driver);

            TMPage tmPageObj = new TMPage();

            tmPageObj.DeleteTime(driver);
      }

       

    }
}




