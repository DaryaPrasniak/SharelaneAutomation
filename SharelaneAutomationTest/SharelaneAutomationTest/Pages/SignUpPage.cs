using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Pages
{
    internal class SignUpPage : BasePage
    {
        By SignUpLocator = By.LinkText("Sign up");
        By ZipCodeLocator = By.Name("zip_code");
        By ContinueButton = By.XPath("//input[@value='Continue']");
        By FirstNameLocator = By.Name("first_name");
        By EmailLocator = By.Name("email");
        By Password1Locator = By.Name("password1");
        By Password2Locator = By.Name("password2");
        By RegisterButtonLocator = By.XPath("//input[@value='Register']");

        public SignUpPage(WebDriver driver) : base(driver) { }

        public void ClickSignUp()
        {
            ChromeDriver.FindElement(SignUpLocator).Click();
        }

        public void SetZipCode(string zipCode)
        {
            ChromeDriver.FindElement(ZipCodeLocator).SendKeys(zipCode);
        }

        public void ClickContinueButton()
        {
            ChromeDriver.FindElement(ContinueButton).Click();
        }

        public void SetFirstName(string firstName)
        {
            ChromeDriver.FindElement(FirstNameLocator).SendKeys(firstName);
        }

        public void SetEmail(string email)
        {
            ChromeDriver.FindElement(EmailLocator).SendKeys(email);
        }

        public void SetPassword1(string password)
        {
            ChromeDriver.FindElement(Password1Locator).SendKeys(password);
        }

        public void SetPassword2(string password)
        {
            ChromeDriver.FindElement(Password2Locator).SendKeys(password);
        }

        public void ClickRegisterButton()
        {
            ChromeDriver.FindElement(RegisterButtonLocator).Click();
        }

        public void SignUp(string zipCode, string firstName, string email, string password)
        {
            ClickSignUp();
            SetZipCode(zipCode);
            ClickContinueButton();
            SetFirstName(firstName);
            SetEmail(email);
            SetPassword1(password);
            SetPassword2(password);
            ClickRegisterButton();
        }
    }
}
