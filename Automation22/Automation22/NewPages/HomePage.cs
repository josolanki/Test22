using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation22.NewPages
{
    public class HomePage
    {
        public void GoToTmPage(IWebDriver driver) 
        {
            // navigate to Time and Material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

        }
        public void GotoEmployeePage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            // click Administration button
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationButton.Click();
            Thread.Sleep(1500);

            // identify time&meterials button
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
            Thread.Sleep(1000);


        }

    }
}
