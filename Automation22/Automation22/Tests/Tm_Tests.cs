using Automation22.NewPages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Automation22.Utilities;

namespace Automation22.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user is able to create a new record with valid data")]
        public void CreatTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTmPage(driver);


            //TM page intilization and defination
            TMPage tmpageObj = new TMPage();
            tmpageObj.CreateTM(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit an existing record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTmPage(driver);

            TMPage tmPageObj = new TMPage();
            //tmPageObj.EditTM(driver);

        }
        [Test, Order(3), Description("Check if user is able to delete existing record successfully")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTmPage(driver);
            TMPage tmpaageObj = new TMPage();
            tmpaageObj.DeleteTM(driver);

        }

    }
}
