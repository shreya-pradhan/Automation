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
    public  class Upload
    {

        [Test]
        public void Verify_Uploads()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Manage().Window.Maximize();
            webdriver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));

            var upload_file = webdriver.FindElement(By.XPath("//input[@name='photo']"));
            upload_file.SendKeys("C:\\Automation\\Automation\\SeleniumPractice\\ConsoleApp1\\testimage.jpg");

            //var filepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\testimage.jpg";
            //upload_file.SendKeys(filepath);

            Thread.Sleep(3000);
            //webdriver.Quit();
        }



    }
}
