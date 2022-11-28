using Auto.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Auto.utilities;

namespace Auto.Test
{
    [TestFixture]

    public class TM_Test : CommonDriver
    {
        [SetUp]
        public void loginSteps()
        {

            driver = new ChromeDriver();
            //Login page Object intilazation and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);


            //Home Page  Object intilazation and defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test, Order(1)]
        public void CreatTM_Test()
        {
            //TM page Object intilazation and defination
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }
        [Test, Order(2)]
        public void EditTM_Test()

        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }




    }



}            
                
        
        
        
        
        
        
        
        
          
               
            
                


                

               
            
        
    

