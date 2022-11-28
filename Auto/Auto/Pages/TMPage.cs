using Auto.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
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

            // click on Create New button
            Thread.Sleep(1500);
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            Thread.Sleep(500);

            //select typecode from the dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();

            Thread.Sleep(1500);

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
            pricePerUnit.SendKeys("250");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(1500);

            //click on last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            gotoLastPageButton.Click();
            //Thread.Sleep(1000);

            Wait.WaitForWebElementtobeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 12);


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
            // edit my new Time record and verify the edited value
            Console.WriteLine("Edit the new Time record");

            // find edit button in last row
            // replace digit in tr[] with last() to get last row in table
            //IWebElement lasteditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            //lasteditButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            // edit the code in the Code textbox, clearing the value before entering the new value
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("my edited time code");

            // find and click Save button
            //IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
            //saveButton2.Click();
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);

            // check if edited time record has been updated successfully
            // find and click on the Go to the last page button
            //IWebElement lastpageButton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //lastpageButton2.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

            // replace digit in tr[] with last() to get last row in table
            //IWebElement lastrowCode2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (lastrowCode2.Text == "my edited time code")
            if (driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")).Text == "my edited time code")
            {
                Console.WriteLine("Time record was edited successfully");
            }
            else
            {
                Console.WriteLine("Time record wasn't edited successfully");
                driver.Quit();
                Environment.Exit(0);
                //    Console.WriteLine("--program continues to run because I do not know how to stop it");
            }

            // delete my edited Time record and verify it was deleted by not finding it in the last row
            // because I don't know how to extract the total rec cnt from the lower-right corner
            Console.WriteLine("Delete the new & edited Time record");

            // find and click Delete button in last row by replacing digit in tr[] with last()
            //IWebElement lastdeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            //lastdeleteButton.Click();
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            Thread.Sleep(500);

            // click OK button in pop-up confirmation window - item is deleted and user remains on last page
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);


           
            

        }
    }
}
