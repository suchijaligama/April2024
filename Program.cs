// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open Chrome browser
IWebDriver webDriver = new ChromeDriver();
webDriver.Manage().Window.Maximize();

// Launch TurnUp portal and navigate to login page
webDriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = webDriver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = webDriver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Check if user has logged in sucessfully
IWebElement helloHarilink = webDriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHarilink.Text == "Hello hari!")
{
    Console.WriteLine("user has logged in successfully");
}
else
{
    Console.WriteLine("user hasn't been logged in.");
}
// Check if user has logged in successful

//Create a new Time/Material record

//Navigate to Time and Material module(Click Administration button -> select Time & Material Option)


//click on the create new button

//select time from dropdown

//Enter code

//Enter Description

//Enter Price per unit

//Click on Save button

//Check if a new time/material record has been created