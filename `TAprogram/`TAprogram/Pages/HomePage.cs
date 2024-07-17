using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _TAprogram.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TAprogram.Pages
{

    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            //click on administration module
            IWebElement administrationTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTextbox.Click();

            wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            //click on time and material
            IWebElement timeAndMaterialTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialTextbox.Click();
        }
        public void NavigateToEmployeePage(IWebDriver driver)
        {
            //click on administration module
            IWebElement administrationTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTextbox.Click();

            wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            //click on time and material
            IWebElement EmployeeTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeeTextbox.Click();
        }

    }
}
