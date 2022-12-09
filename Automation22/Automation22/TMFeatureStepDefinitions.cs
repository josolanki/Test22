using Automation22.NewPages;
using Microsoft.VisualBasic;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Automation22
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into Turnup Portal")]
        public void GivenILoggedIntoTurnupPortal()
        {
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTmPage(driver);
        }

        [When(@"I create new Time record")]
        public void WhenICreateNewTimeRecord()
        {
            // TM Page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Then(@"The reocrd should be created successfully")]
        public void ThenTheReocrdShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Auto", "Actual code and expected code do not match.");
            Assert.That(newDescription == "Auto", "Actual description and expected description do not match");
            Assert.That(newPrice == "$20.00", "Actual price and expeected price do not match.");


        }
        [When(@"I updated '([^']*)' on and exsiting time record")]
        public void WhenIUpdatedOnAndExsitingTimeRecord(string description)
        {
            tmPageObj.EditTM(driver, description);
        }

        [Then(@"I update '([^']*)', '([^']*)', '([^']*)' on an existing time record")]
        public void ThenIUpdateOnAnExistingTimeRecord(string description, string code, string price)

        {
            string editedDescription = tmPageObj.GetDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            Assert.That(editedDescription == description, "Actual desription and expected description do not match");
            Assert.That(editedCode == code, "Actual code and expected code do not match");
            Assert.That(editedPrice == price, "Actual price and expected price do not match");
        }
    }
}
 
    