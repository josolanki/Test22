
using OpenQA.Selenium.Chrome;

namespace Automation22.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]

        public void LoginSteps() 
        {
            driver = new ChromeDriver();
            //Login page object intilaztion and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }
        [OneTimeTearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }


    }
}
