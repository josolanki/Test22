
namespace Automation22.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]

        public void LoginSteps() 
        {
            //Login page object intilaztion and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }


    }
}
