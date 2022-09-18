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
    public  class Frames
    {

        [Test]
        public void Verify_Frames_By_Element()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Manage().Window.Maximize();

            webdriver.Url = "https://demoqa.com/frames";

            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            //webdriver.FindElement(By.CssSelector("button#alertButton")).Click();
            var frame = webdriver.SwitchTo().Frame(webdriver.FindElement(By.CssSelector("#frame1")));
            var frameText=frame.FindElement(By.CssSelector("#sampleHeading")).Text;
            Assert.AreEqual("This is a sample page", frameText);
            webdriver = frame.SwitchTo().ParentFrame();
            webdriver.Quit();
        }


        [Test]
        public void Verify_Frame_By_Number()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Manage().Window.Maximize();

            webdriver.Url = "https://demoqa.com/frames";

            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            //webdriver.FindElement(By.CssSelector("button#alertButton")).Click();
            var frame = webdriver.SwitchTo().Frame(2);
            var frameText = frame.FindElement(By.CssSelector("#sampleHeading")).Text;
            Assert.AreEqual("This is a sample page", frameText);
            webdriver = frame.SwitchTo().ParentFrame();
            webdriver.Quit();
        }



       


    }
}
