using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using StackoverflowAutomation.Test.Pages;

namespace StackoverflowAutomation.Test
{
    class StackoverflowTest
    {
        public const String USERNAME = "bakericecream@gmail.com";
        public const String PASSWORD = "stackoverflowpassword1009";

        [Test]
        public void OneCanLoginStackoverflow()
        {
            IWebDriver driver = new FirefoxDriver();
            StartPage startPage = new StartPage(driver);
            String title = startPage.OpenPage().SignIn().Login(USERNAME, PASSWORD).GetPageTitle();
            Console.WriteLine(title);
        }
    }
}
