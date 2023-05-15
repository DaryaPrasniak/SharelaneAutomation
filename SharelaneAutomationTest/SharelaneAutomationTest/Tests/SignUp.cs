using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SharelaneAutomationTest.Pages;
using System;

namespace SharelaneAutomationTest
{
    internal class SignUp : BaseTest
    {
        [Test]
        public void Test1()
        {
            string zipCode = "123456";
            string firstName = "Test";
            string email = "testuser@gmail.com";
            string password = "123zxc";

            SignUpPage.SignUp(zipCode, firstName, email, password);
           
            Assert.AreEqual("Account is created!", SignUpPage.ConfirmationMessage());
        }
    }
}