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
            string email = "amit_wang@955.33.sharelane.com";
            string password = "1111";
            string welcomeText = "Hello Amit";

            LoginPage.SetEmail(email);
            LoginPage.SetPassword(password);
            LoginPage.ClickLoginButton();         

            Assert.Multiple(() =>
            {
                Assert.AreEqual(welcomeText, LoginPage.HelloText());
                Assert.IsTrue(LoginPage.LogoutLink());
            });

            Assert.IsTrue(LoginPage.CheckLogoutLink());

        }

        [Test]
        public void Test2()
        {
            string email = "amit_wang@955.33.sharelane.com";
            string password = "1111";

            LoginPage.Login(email, password);
            LoginPage.Logout();

            //var logoutText = ChromeDriver.FindElement(By.ClassName("confirmation_message"));
            Assert.AreEqual("You've been logged out", LoginPage.LogoutText());
        }
    }
}