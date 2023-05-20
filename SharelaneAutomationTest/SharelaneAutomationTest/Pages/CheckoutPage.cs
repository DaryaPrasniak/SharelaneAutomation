using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Pages
{
    internal class CheckoutPage :BasePage
    {
        By cardTypeLocator = By.XPath("//option[2]");
        By cardNumberLocator = By.Name("card_number");
        By makePaymentLocator = By.XPath("//input[@value='Make Payment']");

        public CheckoutPage(WebDriver driver) : base(driver) { }

        public void SetCardType()
        { 
        ChromeDriver.FindElement(cardTypeLocator).Click();
        }

        public void SetCardNumber(string cardNumber)
        {
            ChromeDriver.FindElement(cardNumberLocator).SendKeys(cardNumber);
        }

        public void ClickMakePaymentButton()
        {
            ChromeDriver.FindElement(makePaymentLocator).Click();
        }
    }
}
