using Auto.Pages.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Pages
{
    public class EmployeePage : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //click on create button
            IWebElement createEmployeeButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createEmployeeButton.Click();
            // enter value in Name Textbox
            IWebElement nameTextbox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            nameTextbox.SendKeys("Don");
            //enter value in Username Textbox
            IWebElement usernameTextbox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
            usernameTextbox.SendKeys("Don");
            //enter value in Contact Textbox
            IWebElement contactTextbox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactTextbox.SendKeys("454545");
            //enter value in password Textbox
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            passwordTextbox.SendKeys("Tas");
            //enter value in ReTypepassword Textbox
            IWebElement retypepasswordTextbox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            retypepasswordTextbox.SendKeys("Tas");
            //enter value in Vehicle Textbox
            // IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            //   nameTextbox.SendKeys("car");
            //enter value in Groups Textbox
            // IWebElement groupTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            // groupTextbox.SendKeys("Group");

            //click on save button
            IWebElement saveemployeeButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveemployeeButton.Click();
            Thread.Sleep(3000);
            IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolistButton.Click();
            Thread.Sleep(500);
            //goto lastpage
            IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoemployeelastpage.Click();
            //check if Employee record create successfully
            IWebElement newnameTextbox = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        }

        public void EditEmployee(IWebDriver driver)
        {
            // click on last button
            IWebElement lastbutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastbutton.Click();
            Thread.Sleep(500);
            //click on edit button
            IWebElement editemployeeButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editemployeeButton.Click();
            //enter new value in name textbox
            IWebElement newname = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            newname.Clear();
            newname.SendKeys("Tasha");
            //click on save button
            IWebElement save = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            save.Click();
            //click on back to list button
            IWebElement backtolist = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolist.Click();
            // click on last button
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (name.Text == "Tasha")
            {
                Console.WriteLine("New record created successfully");

            }
            else

            {
                Console.WriteLine("New record hasn't been created.");

            }
        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // click on last button
            IWebElement lastbutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastbutton.Click();
            Thread.Sleep(500);
            IWebElement deleteemployeeButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteemployeeButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
