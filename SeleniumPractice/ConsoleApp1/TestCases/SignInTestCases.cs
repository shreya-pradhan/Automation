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
using ConsoleApp1.PageObjectModel;
using NUnit.Framework.Internal.Commands;

namespace ConsoleApp1.TestCases
{
    public class SignInTestClassExample

    {
        IWebDriver webdriver;
        WebDriverWait driverwait;

        [SetUp]
        public void Init()
        {
            webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            webdriver.Manage().Window.Maximize();
            driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
        }

        [Test]
        [TestCase("shreya19.sp@gmail.com", "Test123$")]

        public void Verify_SignIn_Functionality(string email, string password)
        {
           
            SignInPage signInPage = new SignInPage(webdriver, driverwait);
            signInPage.EnterEmailAddress(email);
            signInPage.EnterPassword(password);
            signInPage.clickOnSignInButton();

        }

        [Test]
        [TestCase("shreya19.sp++123@gmail.com", "Test123$")]
        public void Verify_Validation_In_Sign_Up_Functionality(string email, string password)
        {
            IWebDriver webdriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webdriver.Url = "https://demo.realworld.io/#/login";
            
            WebDriverWait driverwait = new WebDriverWait(webdriver, TimeSpan.FromMilliseconds(3000));
            SignInPage signInPage = new SignInPage(webdriver, driverwait);

            signInPage.EnterEmailAddress(email);
            signInPage.EnterPassword(password);
            signInPage.clickOnSignInButton();
            var errormessage1=signInPage.getErrorMessage();

            Assert.AreEqual(errormessage1, "email or password is invalid");


        }
        [TearDown]
        public void cleanUp()
        {
            webdriver.Quit();

        }


    }
}
