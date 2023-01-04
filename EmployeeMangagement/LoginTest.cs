﻿using EmployeeMangagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangagement
{
    public class LoginTest : AutomationWrapper
    {
  
        [Test]
        public void ValidLoginTest() {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("Admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        
        }
    }
}
