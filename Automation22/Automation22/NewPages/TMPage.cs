using Automation22.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation22.NewPages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver) 
        {
            // click on Create New button

            Thread.Sleep(1500);
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(500);

            // select Time in the typecode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();

            // enter code in the code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Auto");

            // enter description in the description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Auto");
            Thread.Sleep(500);

            // enter price in price per unit textbox
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            overlappingTag.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));


            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            // check if new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
           
            
            //Example 2
            Assert.That(newCode.Text == "Auto", "Actual code and expected code doesnt match");
            
            
            
            
            ////Example 2
            //if (newCode.Text == "Auto")
            //{
            //    Assert.Pass("Time record created successfully");
            //}
            //else
            //{
            //    Assert.Fail("Time reocrd hasnt been created");
            //}
        }
         public void EditTM(IWebDriver driver) 
        {
            //go to last page
            IWebElement GoToLastPagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPagebutton.Click();



            //click edit button
            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();

            //edit codetextbox
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.Clear();
            CodeTextbox.SendKeys("Autonew");
            Thread.Sleep(1500);

            // edit descrtiption box
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.Clear();
            descriptiontextbox.SendKeys("Auto1");

            //editbutton price per unit textbox
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));

            overlappingTag.Click();

            priceTextBox.Clear();
            overlappingTag.Click();
            priceTextBox.SendKeys("25");

            //click on save button
            IWebElement clicksavebutton = driver.FindElement(By.Id("SaveButton"));
            clicksavebutton.Click();
            Thread.Sleep(1500);

            // click go to the last page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            Thread.Sleep(1500);


        }

        public void DeleteTM(IWebDriver driver) 
        {
            //go to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // click delete button
            Thread.Sleep(3000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();

            
        }
    }
}
