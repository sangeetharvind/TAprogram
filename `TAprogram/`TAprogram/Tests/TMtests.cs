using _TAprogram.Utilities;
using NUnit.Framework;
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
    public class TMtests : CommonWebDriver
    {   
        [SetUp]
        public void SetupSteps() 

        {
            // open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definations
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object Initialization and definations
            HomePage homePageobj = new HomePage();
            homePageobj.NavigateToTMPage(driver);
        }

        [Test]
        public void CreateTime_Tests()
        {
            //TM page object create initialization and definations
            TMPage tmPageCreateobj = new TMPage();
            tmPageCreateobj.CreateTimeRecord(driver);
        }

        [Test]
        public void EditTime_Tests()
        {
            //TM page object edit initialization and definations
            TMPage tmPageEditobj = new TMPage();
            tmPageEditobj.EditTimeRecord(driver, "");
        }

        [Test]
        public void DeleteTime_Tests()
        {
            //TM page object delete initialization and definations
            TMPage tmPageDeleteobj = new TMPage();
            TMPage.DeleteTimeRecord(driver);
        }
        
        [TearDown]
        public void CloseTests()
        {
            driver.Quit();

        }

    }
}
