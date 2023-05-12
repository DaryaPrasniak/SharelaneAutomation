using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomationTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest
{
    internal class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }
        public SignUpPage SignUpPage { get; set; }
        public SearchPage SearchPage { get; set; }
        public ShoppingCartPage ShoppingCartPage { get; set; }
        public CheckoutPage CheckoutPage { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/cgi-bin/main.py");
            LoginPage = new LoginPage(ChromeDriver);
            SignUpPage = new SignUpPage(ChromeDriver);
            SearchPage = new SearchPage(ChromeDriver);
            ShoppingCartPage = new ShoppingCartPage(ChromeDriver);
            CheckoutPage = new CheckoutPage(ChromeDriver);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
