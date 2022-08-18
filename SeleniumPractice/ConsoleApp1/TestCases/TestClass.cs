using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1.TestCases
{
    public class TestClass

    {

        /*static void main(string[] args)
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Url = "https://demo.realworld.io/#/register";
        }*/
        [Test]
        public void Verify_Navigation_To_Test_App()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            Thread.Sleep(3000);
            webdriver.FindElement(By.CssSelector("input.ng-valid-email")).SendKeys("shreya19.sp@gmail.com");
            webdriver.FindElement(By.CssSelector("input.ng-valid-parse")).SendKeys("Test123$");
            webdriver.FindElement(By.CssSelector(".btn-primary")).Click();

            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            driverwait.Until(e => e.FindElement(By.CssSelector(".navbar-nav")));
            //webdriver.Quit();

        }

    }
}
