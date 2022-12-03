
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Auto.Pages.Utilities
{
    public class CommonDriver
    {
        //public static IWebDriver driver;
        public IWebDriver driver;

        //[SetUp]
        [OneTimeSetUp]
        public void LoginSteps()

        {
            driver = new ChromeDriver();
            //import loginpage here
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginAction(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
