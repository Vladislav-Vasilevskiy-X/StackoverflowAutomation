using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace StackoverflowAutomation.Test.Pages
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement inputLogin;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement inputPassword;

        [FindsBy(How = How.Id, Using = "submit-button")]
        private IWebElement buttonEnter;

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String GetPageTitle()
        {
            return driver.Title.ToString();
        }

        public HomePage Login(String username, String password)
        {
            inputLogin.SendKeys(username);
            inputPassword.SendKeys(password);
            buttonEnter.Click();

            return new HomePage(this.driver);
        }
    }
}
