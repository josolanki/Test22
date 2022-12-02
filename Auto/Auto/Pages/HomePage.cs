using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Auto.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver) 
        {
            // navigate to Time and Material Page
            IWebElement administionDropd = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administionDropd.Click();
            Thread.Sleep(500);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(2000);
        }

        public void CreateEmployeePage(IWebDriver driver)
        {
            // click on the admistrationPage

            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationMenu.Click();
            Thread.Sleep(1500);

            //click on Time&Material module from dropdown
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            employeeOption.Click();
            Thread.Sleep(1000);
        }

        internal void gotoTMpage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }

    
}

