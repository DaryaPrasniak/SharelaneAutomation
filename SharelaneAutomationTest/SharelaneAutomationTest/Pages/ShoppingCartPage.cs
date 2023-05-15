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
        By BookLocator = By.XPath("//table/tbody/tr/td[1]/table/tbody/tr[3]/td/a");
        By ShoppingCartLocator = By.LinkText("Shopping Cart");
        By QuantityInputLocator = By.Name("q");
        By UpdateButtonLocator = By.XPath("//input[@value='Update']");
        By ProceedToCheckoitButton = By.XPath("//input[@value='Proceed to Checkout']");
        By DiscountPercentageLocator = By.XPath("//table/tbody/tr[2]/td[5]/p/b");

        public ShoppingCartPage(WebDriver driver) : base(driver) { }

        public void ClickBookLink()
        { 
          ChromeDriver.FindElement(BookLocator).Click();
        }

        public void ClickShoppingCartLink()
        { 
          ChromeDriver.FindElement(ShoppingCartLocator).Click();
        }

        public void ClearQuantityField()
        {
            ChromeDriver.FindElement(QuantityInputLocator).Clear();
        }

        public void SetBookQuantity(string quantityInput)
        {
            ChromeDriver.FindElement(QuantityInputLocator).SendKeys(quantityInput);
        }

        public void ClickUpdateButton()
        { 
          ChromeDriver.FindElement(UpdateButtonLocator).Click(); 
        }

        public void ClickProceedToCheckoutButton()
        { 
          ChromeDriver.FindElement(ProceedToCheckoitButton).Click();
        }

        public string DiscountPercentage()
        {
            return ChromeDriver.FindElement(DiscountPercentageLocator).Text;
        }
    }
}
