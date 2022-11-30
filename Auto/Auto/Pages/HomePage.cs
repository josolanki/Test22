using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Auto.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver) 
        {
            // click on the admistrationPage

            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationMenu.Click();

            //click on Time&Material module from dropdown
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();

        }

        public void CreateEmployeePage(IWebDriver driver)
        {
            // click on the admistrationPage

            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationMenu.Click();

            //click on Time&Material module from dropdown
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();
        }

        internal void gotoTMpage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }

    
}

