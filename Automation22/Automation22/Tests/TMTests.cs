
// Open chorme browser
using Automation22.NewPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

IWebDriver driver = new ChromeDriver();

//Login page object intilaztion and defination
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

// home page intilization and defination
HomePage homePageObj = new HomePage();
homePageObj.GoToTmPage(driver);

//TM page intilization and defination
TMPage tmpageObj = new TMPage();
tmpageObj.CreateTM(driver);

TMPage tmPageObj = new TMPage();    
tmpageObj.EditTM(driver);


TMPage tmpaageObj = new TMPage();
tmPageObj.DeleteTM(driver);



