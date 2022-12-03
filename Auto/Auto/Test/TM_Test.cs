using Auto.Pages;
using OpenQA.Selenium.Chrome;
using Auto.Pages.Utilities;



namespace Auto.Test
{
      
    public class TM_Test : CommonDriver
        
    {
     

        public void LoginSteps() 
        {
           driver = new ChromeDriver();
            //Login page object intilaization and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);


            // Home page object intilazation and defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
          
          public void CreateTM_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }
          
          public void EditTM_Test()
        {
            // Edit tm object intilazation and defination
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }
          
        public void DeleteTM_Test() 
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver); 
        }
         
        public void CloseTestRun() 
        {
        driver.Quit(); 
        }
            
        
    
    }
}
