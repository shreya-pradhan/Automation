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
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace ConsoleApp1.TestCases
{
    public class SignInTestClass

    {   // sign in test cases using xpath

        [Test]
        public void Verify_SignIn_Functionality()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));


            var username = "1232SP1";
            var email = "shreya19.sp@gmail.com";
            var password = "Test123$";

            webdriver.FindElement(By.XPath("//form/fieldset/fieldset[2]/input[@type='email']")).SendKeys(email);
            webdriver.FindElement(By.XPath("//*[contains(@type,'password')]")).SendKeys(password);
            webdriver.FindElement(By.XPath("//button[text()='Sign in']")).Click();
            driverwait.Until(e => e.FindElement(By.XPath("//a[text()='conduit']")));
            webdriver.Quit();

        }
        [Test]
        public void Verify_SignIn_Functionality1()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));


            var username = "1232SP1";
            var email = "shreya20.sp@gmail.com";
            var password = "Test123$";

            webdriver.FindElement(By.XPath("//form/fieldset/fieldset[2]/input[@type='email']")).SendKeys(email);
            webdriver.FindElement(By.XPath("//*[contains(@type,'password')]")).SendKeys(password);
            webdriver.FindElement(By.XPath("//button[text()='Sign in']")).Click();
            driverwait.Until(e => e.FindElement(By.XPath("//a[text()='conduit']")));
            webdriver.Quit();

        }

        [Test]
        public void Verify_Validation_In_Sign_Up_Functionality()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            var email = "shreya19.sp++123@gmail.com";
            var password = "Test123$";

            webdriver.FindElement(By.XPath("//form/fieldset/fieldset[2]/input[@type='email']")).SendKeys(email);
            webdriver.FindElement(By.XPath("//*[contains(@type,'password')]")).SendKeys(password);
            webdriver.FindElement(By.XPath("//button[text()='Sign in']")).Click();
            driverwait.Until(e => e.FindElement(By.XPath("//list-errors/ul/div/li")));

            var errorMessage1 =webdriver.FindElement(By.XPath("//list-errors/ul/div/li")).Text;
            Assert.AreEqual(errorMessage1, "email or password is invalid");
            webdriver.Quit();


        }


    }
}
