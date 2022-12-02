


//Open Chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//launch trunup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify valid Username Taxtbox and  valid password
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

//identify valid password Textbox and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

//click on login button
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text =="Hello hari!")
{
    Console.WriteLine("logged in successsfully and Test passsed");
}
 else
{
    Console.WriteLine("logged in fail and test failed");
}


// navigate to Time and Material Page
IWebElement administionDropd = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
administionDropd.Click();
Thread.Sleep(500);

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(2000);

Thread.Sleep(2000);
//identify create new
IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNew.Click();

Thread.Sleep(500);
//select typecode from the dropdown
IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCode.Click();

Thread.Sleep(1500);

IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
time.Click();

//Enter code in textbox
IWebElement code = driver.FindElement(By.Name("Code"));
code.SendKeys("250");

//Enter Description
IWebElement description = driver.FindElement(By.Name("Description"));
description.SendKeys("Auto");

//Enter Price per Unit
IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricePerUnit.SendKeys("25");

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


//check whether new record created or not
IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotothelastpage.Click();
// click edit button
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();

// edit code textbox 
IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
editCodeTextbox.Clear();
editCodeTextbox.SendKeys("20");
Thread.Sleep(1500);

// edit description textbox
IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
editDescriptionTextbox.Clear();
editDescriptionTextbox.SendKeys("Auto");
Thread.Sleep(1500);

// edit price per unit textbox
IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));

overlappingTag.Click();
pricePerUnitTextbox.Clear();
overlappingTag.Click();
pricePerUnitTextbox.SendKeys("50");

// click save button
IWebElement clickSavebutton = driver.FindElement(By.Id("SaveButton"));
clickSavebutton.Click();
Thread.Sleep(1500);

// click go to the last page
IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotothelastpageButton.Click();
Thread.Sleep(1500);

//check if the user save record 

Thread.Sleep(2000);

IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

Thread.Sleep(2000);

// click delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();
Thread.Sleep(2000);

// conforming delete ok button
driver.SwitchTo().Alert().Accept();












