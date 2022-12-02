



using Auto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open Chrome browser
IWebDriver driver = new ChromeDriver();

//Login page object intilaization and defination
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginAction(driver);

// Home page object intilazation and defination
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

//TM page objsct intilaztion and defination
TMPage tmPageObj = new TMPage();    
tmPageObj.CreateTM(driver);

tmPageObj.EditTM(driver);

tmPageObj.DeleteTM(driver);  




