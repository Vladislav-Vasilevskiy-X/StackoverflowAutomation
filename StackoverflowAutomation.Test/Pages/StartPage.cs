using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StackoverflowAutomation.Test.Pages
{
    class StartPage
    {
        public const String URL = "http://stackoverflow.com/";

        [FindsBy(How = How.XPath, Using = "//a[@class='login-link' and  text()='log in']")]
        private IWebElement buttonSignIn;

        private IWebDriver driver;

        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public StartPage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            return this;
        }

        public LoginPage SignIn()
        {
            buttonSignIn.Click();
            return new LoginPage(driver);
        }
    }
}
