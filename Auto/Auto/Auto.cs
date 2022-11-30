//open chrome browser
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Auto.Pages;
using Auto.utilities;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();



















// Login Page object intialization
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginAction(driver);

// Home Page object intialization
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM Page object intialization and defination
TMPage tMPageObj = new TMPage();    
tMPageObj.CreateTM(driver);










    


