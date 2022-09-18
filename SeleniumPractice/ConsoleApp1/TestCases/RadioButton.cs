using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp1.TestCases
{
    public  class RadioButton
    {

        [Test]
        public void Verify_RadioButtonss()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Manage().Window.Maximize();
            webdriver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(5000));

            webdriver.FindElement(By.CssSelector("//input[@name='exp']:contains(.,'1')")).Click();

            //webdriver.FindElement(By.CssSelector("//input[@name='exp'][1]")).Click();

            Thread.Sleep(3000);
            webdriver.Quit();
        }



    }
}
