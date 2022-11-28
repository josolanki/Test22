using Auto.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Auto.Pages
{
    public class EmployeePage : CommonDriver
    {
      

        public void CreateEmployeePage(IWebDriver driver)
                
        {
            // Navigate to admistrationPage

            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")); 
            admistrationMenu.Click();
            Thread.Sleep(500);

            IWebElement Employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Employee.Click();

            //Click on Create New button
            IWebElement CreatNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
            CreatNewButton.Click();
            Thread.Sleep(500);


            // Enter name is the text box
            IWebElement EmployeeNameTextBox = driver.FindElement(By.Id("Name"));
            EmployeeNameTextBox.Click();

            // Enter Username in textbox
            IWebElement userNameTextBox = driver.FindElement(By.Id("Username"));
            userNameTextBox.SendKeys("Jo");


            //Enter contact in textbox
            IWebElement contactTextBox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextBox.Click();

            //Enter passwrod in textbox
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("troll");

            //Enter retype password in tetbo
            IWebElement reTypePasswortextBox = driver.FindElement(By.Id("RetypePassword"));
            reTypePasswortextBox.SendKeys("troll");

            //Enter isAdmin in textbox
            IWebElement isAdminTextBox = driver.FindElement(By.Id("check-box"));
            isAdminTextBox.Click();

            //Enter Vahicle in textbox
            IWebElement vahicleTextBox = driver.FindElement(By.Id("VehicleId_input"));
            vahicleTextBox.Click();

            //Enter group in textbox
            IWebElement groupDropDown = driver.FindElement(By.XPath("//*[@id=\"groupList_taglist\"]/li/span[1]"));
            groupDropDown.Click();
            Thread.Sleep(2000);

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            // check if new Employee record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();









        }


    }

}
      


