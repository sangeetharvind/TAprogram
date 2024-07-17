using _TAprogram.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAprogram.Pages
{
    public class LoginPage
    {
        //Functions that allow users to login to TurnUp Portal
        IWebDriver driver = new ChromeDriver();
        public void LoginActions(IWebDriver driver)
        {
         
        // launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io");
        driver.Manage().Window.Maximize();
        Thread.Sleep(2000);

        try
        {
            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            Thread.Sleep(2000);
        }
        
        catch(Exception ex)
        {
                Assert.Fail("Username textbox has not found");
        }

        //wait.WaitToBeVisible(driver, "Id", "Password", 7);

        //Identify password textbox and enter valid password
        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");

        //Identify Login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);

        }

    }
}
