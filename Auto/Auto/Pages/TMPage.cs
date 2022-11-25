using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Pages
{
    public class TMPage 
    {
     public void CreateTM(IWebDriver driver) 
        {

            //click on create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select typecode from the dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();

            Thread.Sleep(1500);//Hold for 1.5 Seconds

            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();

            //Enter code in textbox
            IWebElement code = driver.FindElement(By.Name("Code"));
            code.SendKeys("CS010");

            //Enter Description
            IWebElement description = driver.FindElement(By.Name("Description"));
            description.SendKeys("Auto");

            //Enter Price per Unit
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("2500");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(1500);//Hold for 1.5 Seconds

            //click on last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            gotoLastPageButton.Click();
            Thread.Sleep(1500);//Hold for 1.5 Seconds


            //check whether new record created or not
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "CS010")
            {
                Console.WriteLine("Record created successfully");
            }
            else
            {
                Console.WriteLine("Record not created successfully");
            }


        }

        public void EditTM(IWebDriver driver)
        {

            Thread.Sleep(1000);
            // click edit button in a last row
            IWebElement lasteditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            lasteditButton.Click();


            // edit code textbox 
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("C002");
            Thread.Sleep(1500);

            // edit description textbox
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Auto");
            Thread.Sleep(1500);

            // click save button
            IWebElement clickSavebutton = driver.FindElement(By.Id("SaveButton"));
            clickSavebutton.Click();
            Thread.Sleep(1500);

            // click go to the late page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            Thread.Sleep(1500);
        }

        public void DeleteTM(IWebDriver driver) 
        {
            // click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();
        }
    }
}
