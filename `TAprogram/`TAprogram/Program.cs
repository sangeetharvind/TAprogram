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
        Thread.Sleep(5000);

        //Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //Identify password textbox and enter valid password
        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");

        //Identify Login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);

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
        Thread.Sleep(2000);

        //click on time and material
        IWebElement timeAndMaterialTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialTextbox.Click();
        Thread.Sleep(2000);

        //click on create new button
        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNewButton.Click();
        Thread.Sleep(1000);

        //select Time on dropdown
        IWebElement timeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        timeDropdown.Click();
        Thread.Sleep(1000);

        IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        typecodeDropdown.Click();
        Thread.Sleep(1000);

        //enter text on codeTextbox
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("sangeetha");
        Thread.Sleep(1000);

        //enter text on descriptionTextbox
        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("Test Analyst"); 
        Thread.Sleep(1000);


        IWebElement priceOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceOverLap.Click();
        //enter value on priceTextbox
        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        priceTextbox.SendKeys("200");
        Thread.Sleep(1000);

        //click on save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(1000);

        //assertion ie; going to the last page
        IWebElement assertionButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        assertionButton.Click();

        IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[1]"));
        
        if(newcode.Text == "sangeetha")
        {
            Console.WriteLine("Time record created successfully");

        }
        else
        {
            Console.WriteLine("Time record has not been created");
        }

    }
}
