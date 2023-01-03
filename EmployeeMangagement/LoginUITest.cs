using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeMangagement
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]

        public void BeforeMethod()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://opensource-demo.orangehrmlive.com/\r\n";
        }
        [TearDown]

        public void AfterMethod()
        {
            driver.Quit();
        }
        [Test]

        public void ValidateTitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }
        [Test]
        public void ValidatePlaceholderTest() {

            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));

            }

        }

    }
            







        
