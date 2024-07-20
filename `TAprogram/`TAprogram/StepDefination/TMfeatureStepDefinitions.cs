using _TAprogram.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TAprogram.Pages;
using TechTalk.SpecFlow;

namespace _TAprogram.StepDefination
{
    [Binding]
    public class TMfeatureStepDefinitions : CommonWebDriver
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //Login page object initialization and definations
            TAprogram.Pages.LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            //Home page object Initialization and definations
            HomePage homePageobj = new HomePage();
            homePageobj.NavigateToTMPage(driver);
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            //TM page object create initialization and definations
            TMPage tmPageCreateobj = new TMPage();
            tmPageCreateobj.CreateTimeRecord(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageCreateobj = new TMPage();

            string newCode = tmPageCreateobj.GetCode(driver);
            string newDescription = tmPageCreateobj.GetDescription(driver);
            string newPrice = tmPageCreateobj.GetPrice(driver);

            Assert.That(newCode == "Industry Connect", "Actual Code and Expected Code do not match");
            Assert.That(newDescription == "TA", "Actual Description and Expected Description do not match");
            Assert.That(newPrice == "$200.00", "Actual Price and Expected Price do not match");

        }


        //Edit records

        [When(@"I update the '([^']*)' and '([^']*)'on an existing Time record")]
        public void WhenIUpdateTheOnAnExistingTimeRecord(string code, string description)
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver, code, description);
        }

        [Then(@"the record should have the updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string code , string description)

        {
            TMPage tMPageObj = new TMPage();

            string editCode = tMPageObj.GetCode(driver);
            string editdescription = tMPageObj.GetDescription(driver);

            Assert.That(editCode == code, "Actual and Expected Code do not match");
            Assert.That(editdescription == description, "Actual and Expected description do not match");


        }


    }
}

