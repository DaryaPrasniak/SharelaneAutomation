using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Pages
{
    internal class LoginPage : BasePage
    {
        By EmailLocator = By.Name("email");
        By PasswordLocator = By.Name("password");
        By LoginButtonLocator = By.XPath("//input[@value='Login']");
        By LogoutLocator = By.LinkText("Logout");
        By LogoutTextLocator = By.ClassName("confirmation_message");
        By HelloTextLocator = By.ClassName("user");
        By LogoutLinkLocator = By.LinkText("Logout");

        public LoginPage(WebDriver driver) : base(driver) { }

        public void SetEmail(string email)
        {
            ChromeDriver.FindElement(EmailLocator).SendKeys(email);;
        }

        public void SetPassword(string password)
        {
            ChromeDriver.FindElement(PasswordLocator).SendKeys(password); ;
        }

        public void ClickLoginButton()
        {
            ChromeDriver.FindElement(LoginButtonLocator).Click();
        }

        public void Login(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);
            ClickLoginButton();
        }

        public void Logout()
        {
            ChromeDriver.FindElement(LogoutLocator).Click();
        }

        public bool CheckLogoutLink()
        {
            return ChromeDriver.FindElement(LogoutLocator).Displayed;
        }

        public string LogoutText()
        {
           return ChromeDriver.FindElement(LogoutTextLocator).Text;
        }

        public string HelloText()
        {
            return ChromeDriver.FindElement(HelloTextLocator).Text;
        }

        public bool LogoutLink()
        {
            return ChromeDriver.FindElement(LogoutLinkLocator).Displayed;
        }
    }
}
