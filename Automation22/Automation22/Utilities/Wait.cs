using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation22.Utilities
{
    public class Wait
    { 
        public void WaitForElement(IWebDriver driver) 
        {
        var wait = new WebDriverWait(driver, new TimeSpan(0, 0 , 5));

        }
    }
}
