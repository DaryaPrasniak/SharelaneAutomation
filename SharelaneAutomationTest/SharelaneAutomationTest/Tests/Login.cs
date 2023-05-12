using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomationTest.Pages;
using System;

namespace SharelaneAutomationTest
{
    internal class Login : BaseTest
    {
        [Test]
        public void Test1() 
        {
            string email = "marina_wang@252.86.sharelane.com";
            string password = "1111";
            string welcomeText = "Hello Marina";

            LoginPage.SetEmail(email);
            LoginPage.SetPassword(password);
            LoginPage.ClickLoginButton();

            var helloText = ChromeDriver.FindElement(By.ClassName("user"));            
            var logoutLink = ChromeDriver.FindElement(By.LinkText("Logout"));

            Assert.Multiple(() =>
            {
                Assert.AreEqual(welcomeText, helloText.Text);
                Assert.IsTrue(logoutLink.Displayed);
            });

            Assert.IsTrue(LoginPage.CheckLogoutLink());

        }

        [Test]
        public void Test2()
        {
            string email = "marina_wang@252.86.sharelane.com";
            string password = "1111";

            LoginPage.Login(email, password);
            LoginPage.Logout();

            var logoutText = ChromeDriver.FindElement(By.ClassName("confirmation_message"));
            Assert.AreEqual("You've been logged out", logoutText.Text);
        }
    }
}