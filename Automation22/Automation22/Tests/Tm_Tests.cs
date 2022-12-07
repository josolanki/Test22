using Automation22.NewPages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Automation22.Utilities;

namespace Automation22.Tests
{
    [TestFixture]   
    public class Tm_Tests : CommonDriver

    {
        [SetUp]
        public void LoginSteps() 
        {
             driver = new ChromeDriver();
            //Login page object intilaztion and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            // home page intilization and defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTmPage(driver);
        }
        [Test]
        public void CreateTM_Test() 
        {
            //TM page intilization and defination
            TMPage tmpageObj = new TMPage();
            tmpageObj.CreateTM(driver);
        }
        [Test]
        public void EditTM_Test() 
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
          
        }
        [Test]
        public void DeleteTM_Test() 
        {
            TMPage tmpaageObj = new TMPage();
            tmpaageObj.DeleteTM(driver);
            
        }
        [TearDown]
        public void CloseTestrun() 
        {
        driver.Quit();  
        }
        
        
      

      

       

      


      
    }
}
