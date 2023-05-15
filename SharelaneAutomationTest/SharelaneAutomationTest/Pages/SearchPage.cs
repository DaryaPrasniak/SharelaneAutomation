using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharelaneAutomationTest.Pages
{
    internal class SearchPage : BasePage
    {
        By SearchInputLocator = By.Name("keyword");
        By SearchButtonLocator = By.XPath("//input[@value='Search']");
        By addToCartButton = By.XPath("//table/tbody/tr/td[2]/p[2]/a");
        By addToCartButton1Locator = By.XPath("//table/tbody/tr[5]/td/table[2]");

        public SearchPage(WebDriver driver) : base(driver) { }

        public void InputSearchText(string searchText)
        {
            ChromeDriver.FindElement(SearchInputLocator).SendKeys(searchText);
        }

        public void ClickSearchButton()
        {
            ChromeDriver.FindElement(SearchButtonLocator).Click();
        }

        public void Search(string searchText)
        {
            InputSearchText(searchText);
            ClickSearchButton();
        }

        public void ClickAddToCartButton()
        {
            ChromeDriver.FindElement(addToCartButton).Click();
        }

        public void AddToCartButton1()
        {
            ChromeDriver.FindElement(addToCartButton1Locator);
        }
    }
}
