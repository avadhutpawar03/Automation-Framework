using EmployeeMangagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangagement
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("Admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            String actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("\"https://opensource-demo.orangehrmlive.com/web/index.php/auth/login\";"));
        }
        public static object[] InvalidLogin()
        { 
        string[] dataset1 = new string[3];
        dataset1[0] = "john";
            dataset1[1] = "john123";
            dataset1[2] = "Invalid Credential";

            string[] dataset2 = new string[3];
        dataset2[0] = "peter";
            dataset2[1] = "peter123";
            dataset2[2] = "Invalid Credential";

            string[] dataset3 = new string[3];
        dataset3[0] = "saul";
            dataset3[1] = "saul123";
            dataset3[2] = "Invalid Credential";

            object[] allDataSet = new object[3];
        allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;
            allDataSet[2] = dataset3;

            return allDataSet;
        }

    [Test,TestCaseSource(nameof(InvalidLogin))]



    //[Test]
    //[TestCase("john","john123","Invalid Credential")]
    //[TestCase("peter","peter123","Invalid Credential")]

    public void InvalidLoginTest( string username, string password, string expectedError)
                {
                    driver.FindElement(By.Name("username")).SendKeys(username);
                    driver.FindElement(By.Name("password")).SendKeys(password);
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string actualError= driver.FindElement(By.XPath("//p[normalize-space()='Invalid credentials']")).Text;
            //  Console.WriteLine(acutalError.ToUpper());

            Assert.That(actualError.Contains(expectedError),"Assert wrong details");

                }



            }
        }
    

