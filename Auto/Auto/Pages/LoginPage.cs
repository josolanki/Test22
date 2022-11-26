using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Auto.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver) 

        {
           
            driver.Manage().Window.Maximize();

            //launch trunup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

             try 
            {
                //identify the username text box and valid username

                IWebElement UserNameTaxtBox = driver.FindElement(By.Id("UserName"));
                UserNameTaxtBox.SendKeys("hari");
            }
             catch(Exception ex) 
            {
                Assert.Fail("Turnup Portal did not launch", ex.Message);
            }
            //identify the username text box and valid username

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //identify the password and valid password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify the login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }

      
        
        
       
    }
}
