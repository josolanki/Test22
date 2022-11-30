using Auto.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Auto.utilities;
using static System.Net.Mime.MediaTypeNames;

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
        

        [Test, Order(2), Description("Check if user is able to edit record with valid data")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            //tmPageObj.EditTM(driver);
        }

        public void DeleteTM_Test() 
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            // click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();

            // Click OK on Alert popup Window 

            driver.Navigate().Refresh();

            //VALIDATE DELETE
            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            if (deletedRecord.Text != "C002")
            {
                Assert.Pass("Record has been deleted successfully ");
            }
            else
            {
                Assert.Fail("Record hasn't been deleted");
            }



        }
    }
        

        
        
    
        







    
}

        
            
        




    



            
                
        
        
        
        
        
        
        
        
          
               
            
                


                

               
            
        
    

