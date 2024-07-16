using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _TAprogram.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TAprogram.Pages
{

    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();


            //select Time on dropdown
            IWebElement timeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            timeDropdown.Click();
            Thread.Sleep(2000);


            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typecodeDropdown.Click();
            Thread.Sleep(2000);


            //enter text on codeTextbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TA Program");


            //enter text on descriptionTextbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Test Analyst");



            IWebElement priceOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceOverLap.Click();
            //enter value on priceTextbox
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("200");


            wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);


            //assertion ie; going to the last page
            IWebElement assertionButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            assertionButton.Click();
            Thread.Sleep(2000);

            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode.Text == "TA Program")
            {
                Assert.Pass("Time record created successfully");

            }
            else
            {
                Assert.Fail("Time record has not been created");
            }

        }
        public void EditTimeRecord(IWebDriver driver)
        {
            //assertion ie; going to the last page
            IWebElement pageLastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            Thread.Sleep(2000);
            pageLastButton.Click();
            Thread.Sleep(2000);

            //click the button EDIT
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[1]"));
            Thread.Sleep(1000);
            editButton.Click();


            //edit or change dropdown from Time to Material
            IWebElement editDropdown = driver.FindElement(By.Id("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
            Thread.Sleep(2000);
            editDropdown.Click();
            Thread.Sleep(2000);


            IWebElement editToTimeDropdown = driver.FindElement(By.Id("TypeCode_option_selected"));
            editToTimeDropdown.Click();
            Thread.Sleep(2000);

            //edit or change code from TA Program to Program
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("ABC");


            //edit or change description from Test Analyst to ANALYST
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("SSS");
            Thread.Sleep(2000);


            IWebElement editPriceTextboxx = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTextboxx.Click();
            Thread.Sleep(2000);


            //edit or change price from 20 to 6000
            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            //editPriceTextboxx.Clear();

            editPriceTextbox.SendKeys(Keys.Backspace);
            editPriceTextbox.SendKeys(Keys.Backspace);
            editPriceTextbox.SendKeys(Keys.Backspace);

            editPriceTextbox.SendKeys("60");


            Thread.Sleep(2000);

            IWebElement editSaveButton = driver.FindElement(By.Id("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[8]/td[5]/a[1]"));
            editSaveButton.Click();

            //assertion ie; going to the last page
            //pageLastButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            //pageLastButton.Click();
            //Thread.Sleep(2000);

            IWebElement neweditcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            if (neweditcode.Text == "ABC")
            {
                Assert.Pass("Time record edited");
            }
            else
            {
                Assert.Fail("Time record has not been edited");
            }

        }
        public static void DeleteTimeRecord(IWebDriver driver)
        {
            //click delete button
            IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            Thread.Sleep(2000);

            lastpageButton.Click();
            Thread.Sleep(2000);
            IWebElement delrecord = driver.FindElement(By.XPath("//tr[last()]/td[last()]/a[2]"));
            delrecord.Click();
            Thread.Sleep(2000);
            IAlert Deletealert = driver.SwitchTo().Alert();
            Deletealert.Accept();
            Console.WriteLine("Time record deleted");
        }


    }
}
