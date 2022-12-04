


namespace Auto.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver) 
        {
            new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch trunup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            
            
             //identify valid Username Taxtbox and  valid password
             IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
              usernameTextBox.SendKeys("hari");
            

            //identify valid password Textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //click on login button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbutton.Click();
        }
    }
}
