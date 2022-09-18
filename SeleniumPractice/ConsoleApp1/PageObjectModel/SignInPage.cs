using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PageObjectModel
{
    public class SignInPage
    {
        private IWebDriver webdriver;
        private WebDriverWait driverwait;

        public SignInPage(IWebDriver driver , WebDriverWait driverWait)
        {
            this.webdriver = driver;
            this.driverwait = driverWait;
        }

        public string emailAddress = "//form/fieldset/fieldset[2]/input[@type='email']";
        public string password= "//*[contains(@type,'password')]";
        public string signInButton = "//button[text()='Sign in']";
        public string pageHeader = "//a[text()='conduit']";
        public string errorMessage= "//list-errors/ul/div/li";



        public void EnterEmailAddress(string email)
        {
            webdriver.FindElement(By.XPath(emailAddress)).SendKeys(email);

        }

        public void EnterPassword(string password)
        {
            webdriver.FindElement(By.XPath(password)).SendKeys(password);

        }

        public void clickOnSignInButton()
        {
           webdriver.FindElement(By.XPath(signInButton)).Click();
            driverwait.Until(e => e.FindElement(By.XPath(pageHeader)));

        }

        public void getpageHeader()
        {
            webdriver.FindElement(By.XPath(pageHeader));
        }
        public string getErrorMessage()
        {
            return webdriver.FindElement(By.XPath(errorMessage)).Text;
        }



}
}
