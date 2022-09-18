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
    public  class Dropdowns

    {

        [Test]
        public void Verify_Dropdowns()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Manage().Window.Maximize();
            webdriver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            SelectElement newselection = new SelectElement(webdriver.FindElement(By.Name("continents")));
            newselection.SelectByIndex(4);
            Thread.Sleep(300);
            webdriver.Quit();
        }

                                    
    }
}
