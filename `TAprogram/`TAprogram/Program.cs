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
    }
}
