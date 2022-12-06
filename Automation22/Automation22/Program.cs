

// Open chorme browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


// Launch Turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);
// identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
// identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// click login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
//check if user has login successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "HelloHari!") 
{
    Console.WriteLine("Logged in successfully, test Passed");
}
 else
{
    Console.WriteLine("Login failed, Test failed");
}

// navigate to Time and Material
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
administrationDropdown.Click();
Thread.Sleep(500);

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();


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
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "Auto") 
{
    Console.WriteLine("Time record created successfully");
}
else
{
    Console.WriteLine("Time reocrd hasnt been created");
}

Thread.Sleep(3000); 
IWebElement goTolastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

// click delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();
Thread.Sleep(1500);

// conforming delete ok button
driver.SwitchTo().Alert().Accept();
 