using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void Test1()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://crusader.bransys.com/#/");
            //driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Id("input-204"));
            webElement.SendKeys("Nikola");
            IWebElement webElement1 = driver.FindElement(By.Id("input-207"));
            webElement1.SendKeys("Jokic");
            webElement1.SendKeys(Keys.Return);

            string error_message = driver.FindElement(By.CssSelector(".red--text")).Text;
            string expected_error = "Incorrect email/username or password";
            Assert.Equals(error_message,expected_error);
            //Assert.IsTrue(driver.FindElement(By.ClassName("red--text")).Text.Contains("Incorrect email/username or password");
            

            driver.Quit();
        }
    }
}