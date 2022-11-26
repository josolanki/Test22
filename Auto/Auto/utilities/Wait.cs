using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Auto.utilities    
{
    public class Wait
    {
        public static void WaitForWebElementtobeClickable(IWebDriver driver, string locator, string locatorValue, int Seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
            if (locator == "XPath") 
            {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locator == "Id") 
            {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector") 
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
        }

        public static void WaitForWebElementtoExit(IWebDriver driver, string locator, string locatorValue, int Seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
        }

    }
}
