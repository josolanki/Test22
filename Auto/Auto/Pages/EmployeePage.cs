using Auto.utilities;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Auto.Pages
{
    public class EmployeePage : CommonDriver
    {
      

        public void CreateEmployeePage(IWebDriver driver)
                
        {
           

            //Click on Create New button
            IWebElement CreatNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
            CreatNewButton.Click();
            Thread.Sleep(500);


            // Enter name is the text box
            IWebElement EmployeeNameTextBox = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));

            // Enter Username in textbox
            IWebElement userNameTextBox = driver.FindElement(By.XPath("//*[@id=\"Username\"]"));
            userNameTextBox.SendKeys("Jo");


            //Enter contact in textbox
            IWebElement contactTextBox = driver.FindElement(By.XPath("//*[@id=\"ContactDisplay\"]"));
            contactTextBox.Click();

            //Enter passwrod in textbox
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            passwordTextBox.SendKeys("troll");

            //Enter retype password in tetbo
            IWebElement reTypePasswortextBox = driver.FindElement(By.XPath("//*[@id=\"RetypePassword\"]"));
            reTypePasswortextBox.SendKeys("troll");

            //Enter Vahicle in textbox
            IWebElement vahicleTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vahicleTextBox.Click();
            Thread.Sleep(500);
            //Enter group in textbox
            IWebElement groupDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupDropDown.Click();
            Thread.Sleep(2000);

            //click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();

            IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolistButton.Click();
            Thread.Sleep(500);
            //goto lastpage
            IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoemployeelastpage.Click();
            //check if Employee record create successfully
            IWebElement newnameTextbox = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newnameTextbox.Text == "Jo");

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
            newname.SendKeys("Jes");
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
            Assert.That(name.Text == "Jes", "edit did not work");


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






        

     


