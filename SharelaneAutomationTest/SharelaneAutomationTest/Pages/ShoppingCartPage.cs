using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Pages
{
    internal class ShoppingCartPage : BasePage
    {
        By bookLocator = By.XPath("//table/tbody/tr/td[1]/table/tbody/tr[3]/td/a");
        By shoppingCartLocator = By.LinkText("Shopping Cart");
        By quantityInputLocator = By.Name("q");
        By updateButtonLocator = By.XPath("//input[@value='Update']");
        By proceedToCheckoitButton = By.XPath("//input[@value='Proceed to Checkout']");

        public ShoppingCartPage(WebDriver driver) : base(driver) { }

        public void ClickBookLink()
        { 
          ChromeDriver.FindElement(bookLocator).Click();
        }

        public void ClickShoppingCartLink()
        { 
          ChromeDriver.FindElement(shoppingCartLocator).Click();
        }

        public void ClearQuantityField()
        {
            ChromeDriver.FindElement(quantityInputLocator).Clear();
        }

        public void SetBookQuantity(string quantityInput)
        {
            ChromeDriver.FindElement(quantityInputLocator).SendKeys(quantityInput);
        }

        public void ClickUpdateButton()
        { 
          ChromeDriver.FindElement(updateButtonLocator).Click(); 
        }

        public void ClickProceedToCheckoutButton()
        { 
          ChromeDriver.FindElement(proceedToCheckoitButton).Click();
        }
    }
}
