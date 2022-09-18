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
    public class TestClass

    {

        [Test]
        public void Verify_SignUp_Functionality()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/register";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));


            var username = "1232SP1";
            var email = "shreya19.sp+1123@gmail.com";
            var password = "Test123$";

            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(1) input")).SendKeys(username);
            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(2) input")).SendKeys(email);
            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(3) input")).SendKeys(password);
            webdriver.FindElement(By.CssSelector(".btn-primary")).Click();
            driverwait.Until(e => e.FindElement(By.CssSelector(".navbar-nav")));
            webdriver.Navigate().Refresh();
            webdriver.Navigate().Back();
            //webdriver.Navigate().Forward();
           webdriver.Quit();

        }

        [Test]
        public void Verify_Validation_In_Sign_Up_Functionality()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/register";
            
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            var username = "1232SP";
            var email = "shreya19.sp+123@gmail.com";
            var password = "Test123$";

            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(1) input")).SendKeys(username);
            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(2) input")).SendKeys(email);
            webdriver.FindElement(By.CssSelector("form>fieldset>fieldset:nth-of-type(3) input")).SendKeys(password);
            webdriver.FindElement(By.CssSelector(".btn-primary")).Click();

            driverwait.Until(e => e.FindElement(By.CssSelector("ul.error-messages>div:nth-of-type(1) li")));

            var errorMessage1 =webdriver.FindElement(By.CssSelector("ul.error-messages>div:nth-of-type(1) li")).Text;
            var errorMessage2 = webdriver.FindElement(By.CssSelector("ul.error-messages>div:nth-of-type(2) li")).Text;
            Assert.AreEqual(errorMessage1, "email has already been taken");
            Assert.AreEqual(errorMessage2, "username has already been taken");
            //webdriver.Quit();

        }


    }
}
