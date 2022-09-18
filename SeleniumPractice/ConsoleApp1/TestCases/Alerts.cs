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
    public  class Alerts
    {

        [Test]
        public void Verify_Alerts()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demoqa.com/alerts";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            webdriver.FindElement(By.CssSelector("button#alertButton")).Click();
            var alertWindow = webdriver.SwitchTo().Alert();
            var actualAlertMessage = alertWindow.Text;
            Assert.AreEqual("You clicked a button", alertWindow.Text);
            alertWindow.Accept();
            Thread.Sleep(3000);
            //webdriver.Quit();
        }


        [Test]
        public void Verify_ConfirmAlerts()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demoqa.com/alerts";
            webdriver.Manage().Window.Maximize();
            


            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            webdriver.FindElement(By.CssSelector("button#confirmButton")).Click();
            var alertWindow = webdriver.SwitchTo().Alert();
            var actualAlertMessage = alertWindow.Text;
            Assert.AreEqual("Do you confirm action?", alertWindow.Text);
            alertWindow.Accept();

            webdriver.FindElement(By.CssSelector("button#confirmButton")).Click();
            var alertWindow2 = webdriver.SwitchTo().Alert();
            var actualAlertMessage2 = alertWindow2.Text;
            Assert.AreEqual("Do you confirm action?", actualAlertMessage2);
            alertWindow.Dismiss();
            //webdriver.Quit();

        }



        [Test]
        public void Verify_PromptAlerts()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demoqa.com/alerts";
            webdriver.Manage().Window.Maximize();
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));

            driverwait.Until(e => e.FindElement(By.CssSelector("button#promtButton")));
            webdriver.FindElement(By.CssSelector("button#promtButton")).Click();
            var alertWindow = webdriver.SwitchTo().Alert();
            var actualAlertMessage = alertWindow.Text;
            Assert.AreEqual("Please enter your name", alertWindow.Text);
            alertWindow.SendKeys("shreya");
            alertWindow.Accept();
            webdriver.Quit();

        }



    }
}
