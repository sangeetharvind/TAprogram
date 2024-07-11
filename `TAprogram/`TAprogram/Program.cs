using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();

        // launch turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io");
        driver.Manage().Window.Maximize();

        //Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //Identify password textbox and enter valid password
        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");

        //Identify Login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        

        //Click if user has loggedin successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("user has logged in successfully. Test Passed");
        }
        else
        { 
            Console.WriteLine("üser has not logged in. Test Failed");
        }


        //click on administration module
        IWebElement administrationTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTextbox.Click();
       

        //click on time and material
        IWebElement timeAndMaterialTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialTextbox.Click();
        

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
       

        //click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(1000);
        

        //assertion ie; going to the last page
        IWebElement assertionButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        assertionButton.Click();
        Thread.Sleep(2000);
        

        IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        
        if(newcode.Text == "TA Program")
        {
            Console.WriteLine("Time record created successfully");

        }
        else
        {
            Console.WriteLine("Time record has not been created");
        }


        //click the button EDIT
        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
        editButton.Click();
        

        //edit or change dropdown from Time to Material
        IWebElement editDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        editDropdown.Click();
        Thread.Sleep(2000);
       

        IWebElement editToMaterialDropdown = driver.FindElement(By.Id("TypeCode_listbox"));
        editToMaterialDropdown.Click();
        Thread.Sleep(2000);

        //edit or change code from TA Program to Program
        IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
        editCodeTextbox.Clear();
        editCodeTextbox.SendKeys("ABC");
        

        //edit or change description from Test Analyst to ANALYST
        IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
        editDescriptionTextbox.Clear();
        editDescriptionTextbox.SendKeys("SSS");
        

        IWebElement editPriceTextboxx = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        editPriceTextboxx.Click();
        

        //edit or change price from 20 to 6000
        IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
        //editPriceTextboxx.Clear();

        editPriceTextbox.SendKeys(Keys.Backspace);
        editPriceTextbox.SendKeys(Keys.Backspace);
        editPriceTextbox.SendKeys(Keys.Backspace);

        editPriceTextbox.SendKeys("60");


        Thread.Sleep(2000);

        IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
        editSaveButton.Click();
        Thread.Sleep(2000);

        //assertion ie; going to the last page
        IWebElement editLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        editLastPage.Click();
        Thread.Sleep(2000);

        IWebElement neweditcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        Thread.Sleep(2000);

        if (neweditcode.Text == "PROGRAM")
        {
            Console.WriteLine("Time record edited");
        }
        else
        {
            Console.WriteLine("Time record has not been edited");
        }


        //click delete button
        IWebElement delrecord = driver.FindElement(By.XPath("//tbody/tr[last()]/td[last()]/a[2]"));
        delrecord.Click();
        Thread.Sleep(2000);
        IAlert Deletealert = driver.SwitchTo().Alert();
        Deletealert.Accept();
        Console.WriteLine("Time record deleted");
    }
}
