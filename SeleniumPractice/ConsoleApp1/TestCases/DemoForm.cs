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
    public class DemoForm

    {

        [Test]
        public void Verify_Form_Functionality()
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demoqa.com/automation-practice-form";
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));

            webdriver.FindElement(By.CssSelector("input #dateOfBirthInput")).Click();
            SelectElement yearDropdown = new SelectElement(webdriver.FindElement(By.CssSelector(".react-datepicker__month-select")));
            yearDropdown.SelectByValue("August");
            SelectElement monthDropdown = new SelectElement(webdriver.FindElement(By.CssSelector(".react-datepicker__year-select")));
            yearDropdown.SelectByValue("2022");
            webdriver.FindElement(By.CssSelector(".react-datepicker__week:Contains(6)"));

        }


    }
}
