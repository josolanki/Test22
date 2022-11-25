using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Auto.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver) 
        
        {
            
            //launch trunup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


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
