using Auto.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.utilities
{
    public class CommonDriver
    {
       
        public IWebDriver driver;
        [OneTimeSetUp]

        public void loginSteps()
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


        
    



