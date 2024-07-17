using _TAprogram.Pages;
using _TAprogram.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAprogram.Pages;

namespace _TAprogram.Tests
{
    
    [TestFixture]
    public class EmployeeTest : CommonWebDriver

    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [SetUp]
        public void SetupSteps()

        {
            // open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definations
            
            loginPageObj.LoginActions(driver);

            //Home page object Initialization and definations
            
            homePageObj.NavigateToEmployeePage(driver);
        }

        [Test]
        public void CreateEmployee_Tests()
        {
            employeePageObj.CreateEmployeeRecord(driver);
        }

        [Test]
        public void EditEmployee_Tests()
        {
            employeePageObj.EditEmployeeRecord(driver);
        }
        [TearDown]
        public void CloseTests()
        {
            driver.Quit();

        }

        [Test]
        public void DeleteEmployee_Tests()
        {
            employeePageObj.DeleteEmployeeRecord(driver);
        }

        [TearDown]
        public void CloseTests1()
        {
            driver.Quit();

        }
    }
}
